function attachEvents() {
    const url = 'http://localhost:3030/jsonstore/phonebook';

    const ul = document.querySelector('#phonebook');
    const loadBtn = document.querySelector('#btnLoad');
    const createBtn = document.querySelector('#btnCreate');

    const person = document.querySelector('#person');
    const phone = document.querySelector('#phone');

    loadBtn.addEventListener('click', onClickLoad);
    createBtn.addEventListener('click', onClickCreate);

    async function onClickLoad(event) {
        event.preventDefault();
        ul.innerHTML = '';

        const response = await fetch(url);

        if (!response.ok) {
            const error = response.json();
            return alert(error.message);
        }

        const data = await response.json();

        Object.values(data).forEach(x => {
            const { person, phone, _id } = x;

            const li = createElement('li', `${person}: ${phone}`, ul);
            li.setAttribute('id', _id); //скандал!!! :D

            const deleteBtn = createElement('button', 'Delete', li);
            deleteBtn.setAttribute('id', 'btnDelete');
            deleteBtn.addEventListener('click', onClickDelete);

        });

    }

    async function onClickDelete(event) {
        event.preventDefault(); //???

        const id = event.target.parentNode.id;

        event.target.parentNode.remove();

        const deleteResponse = await fetch(`${url}/${id}`, {
            method: 'DELETE'
        });

        if (!deleteResponse.ok) {
            const error = response.json();
            return alert(error.message);
        }


    }

    async function onClickCreate(event) {
        event.preventDefault();

        if (person.value === '' || phone.value === '') {
            alert('All fields are required!');
            return;
        }

        const response = await fetch(url, {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({ person: `${person.value}`, phone: `${phone.value}` })
        });

        person.value = '';
        phone.value = '';

        loadBtn.click();

    }


    function createElement(type, text, appender) {
        const result = document.createElement(type);
        result.textContent = text;
        appender.appendChild(result);

        return result;
    }

}

attachEvents();