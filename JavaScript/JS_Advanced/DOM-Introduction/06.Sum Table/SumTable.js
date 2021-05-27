function sumTable() {

    const rows = document.querySelectorAll('table tr');

    let result = 0;

    for (let i = 1; i < rows.length - 1; i++) {

        let cols = rows[i].children;

        result += Number(cols[cols.length - 1].textContent);
    }

    const sum = document.getElementById('sum');
    sum.textContent = result;
}

//-----different approach-----//

function sumTable() {
    const rows = [...document.querySelectorAll('table tr')].slice(1, -1);

    document.getElementById('sum').textContent = rows.reduce((sum, row) => {
        return sum + Number(row.lastChild.textContent);
    }, 0);
}