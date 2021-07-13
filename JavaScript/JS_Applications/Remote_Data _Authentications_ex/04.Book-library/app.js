function start() {
    document.querySelector('#editForm').style.display = 'none';

    document.querySelector('#loadBooks').addEventListener('click', loadAllBooks);
    document.querySelector('#createForm').addEventListener('submit', onClickCreate);
    document.querySelector('#editForm').addEventListener('submit', onClickEdit);
}

async function loadAllBooks() {
    //event.preventDefault();

    const allBooks = document.querySelector('tbody');
    allBooks.innerHTML = '';

    const response = await fetch('http://localhost:3030/jsonstore/collections/books');

    if (!response.ok) {
        const error = await response.json();
        return alert(error.message);
    }

    const data = await response.json();

    Object.entries(data).forEach(item => {
        const [id, book] = item;

        const row = createElement('tr', null, allBooks);
        row.setAttribute('id', id);

        const titleTr = createElement('td', book.title, row);
        const authorTr = createElement('td', book.author, row);
        const buttons = createElement('td', null, row);

        const editBtn = createElement('button', 'Edit', buttons);
        const deleteBtn = createElement('button', 'Delete', buttons);

        editBtn.addEventListener('click', prepareForEditing);
        deleteBtn.addEventListener('click', onClickDelete);


    });
}

async function onClickDelete(event) {
    event.preventDefault();
    const id = event.target.parentNode.parentNode.id;
    const response = await fetch(`http://localhost:3030/jsonstore/collections/books/${id}`, {
        method: 'DELETE'
    });

    loadAllBooks();
}

async function onClickCreate(event) {
    event.preventDefault();

    const formData = new FormData(event.target);

    const title = formData.get('title');
    const author = formData.get('author');


    if (title == '' || author == '') {
        return alert('All fields are required');
    }

    const response = await fetch('http://localhost:3030/jsonstore/collections/books', {
        method: 'POST',
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ author, title })
    });

    if (!response.ok) {
        const error = await response.json();
        return alert(error.message);
    }

    document.getElementsByName('title')[0].value = '';
    document.getElementsByName('author')[0].value = '';

    loadAllBooks();
}

async function onClickEdit(event) {
    event.preventDefault();

    const formData = new FormData(event.target);

    let title = formData.get('title');
    let author = formData.get('author');
    const id = formData.get('id');

    const response = await fetch(`http://localhost:3030/jsonstore/collections/books/${id}`, {
        method: 'PUT',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ author, title })
    });

    const data = await response.json();

    editForm.querySelector('[name=title]').value = '';
    editForm.querySelector('[name=author]').value = '';

    document.querySelector('#createForm').style.display = 'block';
    document.querySelector('#editForm').style.display = 'none';

    loadAllBooks();

}

async function prepareForEditing(event) {
    event.preventDefault();

    document.querySelector('#createForm').style.display = 'none';
    document.querySelector('#editForm').style.display = 'block';

    const id = event.target.parentNode.parentNode.id;
    const response = await fetch(`http://localhost:3030/jsonstore/collections/books/${id}`);
    const book = await response.json();

    document.querySelector('#editForm [name="id"]').value = id;
    document.querySelector('#editForm [name="title"]').value = book.title;
    document.querySelector('#editForm [name="author"]').value = book.author;
}

function createElement(type, text, appender) {
    const result = document.createElement(type);

    if (text) {
        result.textContent = text;
    }

    appender.appendChild(result);

    return result;
}


start();