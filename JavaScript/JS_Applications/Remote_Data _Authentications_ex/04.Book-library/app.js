function start() {
    document.querySelector('#editForm').style.display = 'none';

    document.querySelector('#loadBooks').addEventListener('click', loadAllBooks);
    document.querySelector('form').addEventListener('submit', onClickCreate);

}

async function loadAllBooks(event) {
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
        console.log(id, book);

        const row = createElement('tr', null, allBooks);
        row.setAttribute('id', id);

        const titleTr = createElement('td', book.title, row);
        const authorTr = createElement('td', book.author, row);
        const buttons = createElement('td', null, row);

        const editBtn = createElement('button', 'Edit', buttons);
        const deleteBtn = createElement('button', 'Delete', buttons);

        editBtn.addEventListener('click', onClickEdit);


    });
}

async function onClickCreate(event) {
    event.preventDefault();

    const formData = new FormData(event.target);

    const title = formData.get('title');
    const author = formData.get('author');


    if (title == '' || author == '') {
        alert('All fields are required');
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

    document.querySelector('#createForm').style.display = 'none';

    const editForm = document.querySelector('#editForm');
    editForm.style.display = 'block';

    const formData = new FormData(editForm);

    const title = event.target.parentNode.parentNode.children[0].textContent;
    const author = event.target.parentNode.parentNode.children[1].textContent;

    editForm.querySelector('[name=title]').value = title;
    editForm.querySelector('[name=author]').value = author;




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