 function solve() {

     const departBtn = document.getElementById('depart');
     const arriveBtn = document.getElementById('arrive');

     const infoBox = document.querySelector('.info');

     let stopId = 'depot';
     let stopName;
     let response;
     let data;
     let url;

     async function depart() {
         arriveBtn.disabled = false;
         departBtn.disabled = true;

         url = `http://localhost:3030/jsonstore/bus/schedule/${stopId}`;

         try {

             response = await fetch(url);

             if (!response.statusText) {
                 throw new Error;
             }

             data = await response.json();

             stopId = data.next;
             stopName = data.name;

             infoBox.textContent = `Next stop ${stopName}`;

         } catch {

             arriveBtn.disabled = true;
             infoBox.textContent = 'Error';
         }
     }

     async function arrive() {
         infoBox.textContent = `Arriving at ${stopName}`;

         departBtn.disabled = false;
         arriveBtn.disabled = true;

     }

     return {
         depart,
         arrive
     };
 }

 let result = solve();