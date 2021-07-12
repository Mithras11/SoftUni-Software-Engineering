async function solve() {
    const url = `http://localhost:3030/jsonstore/collections/students`;

    const table = document.querySelector('tbody');

    const response = await fetch(url);

    if (!response.ok) {
        const error = await response.json();
        return alert(error.message);
    }

    const data = await response.json();

    Object.values(data).forEach(s => {
        const firstName = s.firstName;
        const lastName = s.lastName;
        const facultyNumber = Number(s.facultyNumber);
        const grade = Number(s.grade).toFixed(2);

        const tr = document.createElement('tr');

        const firstNameCell = tr.insertCell(0);
        firstNameCell.innerText = firstName;

        const lastNameCell = tr.insertCell(1);
        lastNameCell.innerText = lastName;

        const facultyNumberCell = tr.insertCell(2);
        facultyNumberCell.innerText = facultyNumber;

        const gradeCell = tr.insertCell(3);
        gradeCell.innerText = grade;

        table.appendChild(tr);

    });

    const submitBtn = document.querySelector('#submit');
    submitBtn.addEventListener('click', onClickSubmit);

    async function onClickSubmit(event) {
        event.preventDefault();

        const firstNameInput = document.getElementsByName('firstName')[0];
        const lastNameInput = document.getElementsByName('lastName')[0];
        const facultyNumberInput = document.getElementsByName('facultyNumber')[0];
        const gradeInput = document.getElementsByName('grade')[0];


        if (firstNameInput.value == '' ||
            lastNameInput.value == '' ||
            facultyNumberInput.value == '' ||
            gradeInput.value == '') {

            return alert('All input fields are required!');
        }

        if (isNaN(facultyNumberInput.value) ||
            isNaN(gradeInput.value)) {

            return alert('Grade and Faculty Number must be Number');
        }


        const response = await fetch(url, {
            method: 'POST',
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify({
                firstName: firstNameInput.value,
                lastName: lastNameInput.value,
                facultyNumber: Number(facultyNumberInput.value),
                grade: Number(gradeInput.value).toFixed(2)
            })
        });

        if (!response.ok) {
            const error = response.json();
            alert(error.message);
            return;
        }



        const tr = document.createElement('tr');

        const firstNameCell = tr.insertCell(0);
        firstNameCell.innerText = firstNameInput.value;

        const lastNameCell = tr.insertCell(1);
        lastNameCell.innerText = lastNameInput.value;

        const facultyNumberCell = tr.insertCell(2);
        facultyNumberCell.innerText = Number(facultyNumberInput.value);

        const gradeCell = tr.insertCell(3);
        gradeCell.innerText = Number(gradeInput.value).toFixed(2);

        table.appendChild(tr);

        firstNameInput.value = '';
        lastNameInput.value = '';
        facultyNumberInput.value = '';
        gradeInput.value = '';

    }
}


solve();