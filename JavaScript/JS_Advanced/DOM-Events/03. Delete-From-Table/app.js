function deleteByEmail() {

    let eMail = document.querySelector('input[name="email"]').value;
    let rows = Array.from(document.querySelectorAll('tbody tr'));

    let deleted = false;
    let result = document.getElementById('result');

    for (const row of rows) {

        //let address = row.querySelectorAll('td')[1].textContent;
        let address = row.children[1].textContent;

        if (address == eMail) {

            deleted = true;

            row.parentElement.removeChild(row);
            result.textContent = 'Deleted.';
        }
    }

    if (deleted === false) {
        result.textContent = 'Not found.';
    }
}

//------ different version------//

function deleteByEmail() {

    let eMail = document.querySelector('input[name="email"]').value;
    let rows = Array.from(document.querySelectorAll('tbody tr'));

    let result = document.getElementById('result');

    let matches = rows.filter(r => r.children[1].textContent === eMail);

    if (matches.length > 0) {

        matches.forEach(r => r.remove());
        result.textContent = 'Deleted.';

    } else {
        result.textContent = 'Not found.';
    }
}