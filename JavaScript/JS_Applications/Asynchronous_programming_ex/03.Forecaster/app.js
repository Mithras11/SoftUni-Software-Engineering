async function attachEvents() {

    const location = document.querySelector('#location').value;
    let url = `http://localhost:3030/jsonstore/forecaster/locations`;

    let response = await fetch(url);

    let data = await response.json();

    const locationCode = data.find(x => x.name === location).code;

    const conditionSymbols = {
        'Sunny': '&#x2600;',
        'Partly sunny': '&#x26C5;',
        'Overcast': '&#x2601;',
        'Rain': '&#x2614;',
        'Degrees': '&#176;'
    }

    //---- current conditions----//

    url = `http://localhost:3030/jsonstore/forecaster/today/${locationCode}`;

    response = await fetch(url);

    data = await response.json();

    let locationName = data.name;
    let [condition, high, low] = Object.values(data.forecast);

    let parentDiv = document.querySelector('#forecast');
    parentDiv.style.display = 'block';

    let currentDiv = document.querySelector('#current');

    let forecastsDiv = createElement('div', 'forecasts', null, currentDiv);

    let symbolSpan = createElement('span', 'condition', null, forecastsDiv);
    symbolSpan.classList.add('symbol');
    symbolSpan.innerHTML = conditionSymbols[condition];

    let conditionSpan = createElement('span', 'condition', null, forecastsDiv);
    let locSpan = createElement('span', 'forecast-data', locationName, conditionSpan);
    let tempSpan = createElement('span', 'forecast-data', `${low}°/${high}°`, conditionSpan);
    let condSpan = createElement('span', 'forecast-data', condition, conditionSpan);


    //------3day forecast----//

    url = `http://localhost:3030/jsonstore/forecaster/upcoming/${locationCode}`

    response = await fetch(url);

    data = await response.json();


    currentDiv = document.querySelector('#upcoming');
    forecastsDiv = createElement('div', 'forecast-info', null, currentDiv);

    data.forecast.forEach(x => {

        [condition, high, low] = Object.values(x);

        let upcomingSpan = createElement('span', 'upcoming', null, forecastsDiv);

        symbolSpan = createElement('span', 'symbol', null, upcomingSpan);
        symbolSpan.innerHTML = conditionSymbols[condition];

        tempSpan = createElement('span', 'forecast-data', `${low}°/${high}°`, upcomingSpan);
        condSpan = createElement('span', 'forecast-data', condition, upcomingSpan);

    });




    function createElement(type, className, text, appender) {

        let result = document.createElement(type);
        result.classList.add(className);
        result.textContent = text;
        appender.appendChild(result);

        return result;
    }

}

attachEvents();