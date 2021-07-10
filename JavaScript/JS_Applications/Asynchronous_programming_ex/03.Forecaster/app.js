 function attachEvents() {

     const submitBtn = document.querySelector('#submit');
     submitBtn.addEventListener('click', getForecasts);

     async function getForecasts() {

         const location = document.querySelector('#location');
         let url = `http://localhost:3030/jsonstore/forecaster/locations`;

         let parentDiv = document.querySelector('#forecast');
         let locationCode;

         const conditionSymbols = {
             'Sunny': '&#x2600;',
             'Partly sunny': '&#x26C5;',
             'Overcast': '&#x2601;',
             'Rain': '&#x2614;',
             'Degrees': '&#176;'
         };

         try {

             let response = await fetch(url);

             if (!response.statusText) {

                 throw new Error;
             }

             let data = await response.json();

             let target = data.find(x => x.name === location.value);

             if (target === undefined) {
                 throw new Error;
             }

             locationCode = target.code;

         } catch {

             handleError();
         }


         //---- current conditions----//

         url = `http://localhost:3030/jsonstore/forecaster/today/${locationCode}`;

         try {

             response = await fetch(url);

             if (!response.statusText) {
                 throw new Error;
             }

             data = await response.json();

             let locationName = data.name;
             let [condition, high, low] = Object.values(data.forecast);

             clearRequestBar();

             let currentDiv = document.querySelector('#current');

             let forecastsDiv = createElement('div', 'forecasts', null, currentDiv);

             let symbolSpan = createElement('span', 'condition', null, forecastsDiv);
             symbolSpan.classList.add('symbol');
             symbolSpan.innerHTML = conditionSymbols[condition];

             let conditionSpan = createElement('span', 'condition', null, forecastsDiv);
             let locSpan = createElement('span', 'forecast-data', locationName, conditionSpan);
             let tempSpan = createElement('span', 'forecast-data', `${low}°/${high}°`, conditionSpan);
             let condSpan = createElement('span', 'forecast-data', condition, conditionSpan);

         } catch {

             handleError();
         }


         //------3-day forecast----//

         url = `http://localhost:3030/jsonstore/forecaster/upcoming/${locationCode}`;

         try {

             response = await fetch(url);

             if (!response.statusText) {
                 throw new Error;
             }

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

         } catch {

             handleError();
         }



         function createElement(type, className, text, appender) {

             let result = document.createElement(type);

             result.classList.add(className);

             if (text) {

                 result.textContent = text;
             }

             appender.appendChild(result);

             return result;
         }

         function handleError() {
             location.value = '';
             parentDiv.style.display = 'block';
             parentDiv.innerHTML = '<div id="current"><div class="label">ERROR</div>';

         }

         function clearRequestBar() {
             location.value = '';
             parentDiv.style.display = 'block';
             parentDiv.innerHTML = '<div id="current"><div class="label">Current conditions</div></div><div id="upcoming"><div class="label">Three-day forecast</div></div>';
         }
     }
 }

 attachEvents();