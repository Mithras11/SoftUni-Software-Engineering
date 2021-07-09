async function getInfo() {

    const stopIdField = document.querySelector('#stopId');
    const stopId = Number(stopIdField.value);

    const stopName = document.querySelector('#stopName');
    const buses = document.querySelector('#buses');
    const validIds = [1287, 1308, 1327, 2334];

    const url = `http://localhost:3030/jsonstore/bus/businfo/${stopId}`;

    try {

        buses.innerHTML = '';

        const response = await fetch(url);

        // if (!response.statusText) {
        //     throw new Error;
        // }

        if (!validIds.includes(stopId)) {
            throw new Error;
        }

        const data = await response.json();

        stopIdField.value = '';
        stopName.textContent = data.name;

        Object.entries(data.buses).forEach(([id, time]) => {
            const li = document.createElement('li');
            li.textContent = `Bus ${id} arrives in ${time}`;
            buses.appendChild(li);
        });

    } catch {
        stopName.textContent = 'Error';
    }




}