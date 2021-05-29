function generateReport() {

    const headers = Array.from(document.querySelectorAll('th')).map(h => h.children[0]);

    const rows = Array.from(document.querySelectorAll('tbody tr'))

    let result = [];

    rows.forEach(row => {

        let currentRow = Array.from(row.children).reduce((obj, prop, indx) => {

            if (headers[indx].checked) {
                let headerName = headers[indx].name;
                obj[headerName] = prop.innerText;
            }

            return obj;

        }, {});

        result.push(currentRow);
    });

    document.querySelector('#output').value = JSON.stringify(result);


}