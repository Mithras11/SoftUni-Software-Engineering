function attachEvents() {
    const url = 'http://localhost:3030/jsonstore/messenger';

    const author = document.getElementsByName('author')[0];
    const content = document.getElementsByName('content')[0];
    const messages = document.querySelector('#messages');

    const submitBtn = document.querySelector('#submit');
    const refreshBtn = document.querySelector('#refresh');

    submitBtn.addEventListener('click', onClickSubmit);
    refreshBtn.addEventListener('click', onClickRefresh);

    async function onClickSubmit(event) {
        event.preventDefault(); //???

        const authorName = author.value;
        const msgText = content.value;

        if (authorName === '' || msgText === '') {
            alert('All fields are required!');
            return;
        }

        const response = await fetch(url, {
            method: 'post',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({ author: authorName, content: msgText })
        });


        if (!response.ok) {
            const error = response.json();
            alert(error.message);
            return;
        }

        author.value = '';
        content.value = '';

    }

    async function onClickRefresh(event) {
        event.preventDefault(); //???

        const response = await fetch(url);

        if (!response.ok) {
            const error = response.json();
            alert(error.message);
            return;
        }

        const data = await response.json();

        Object.values(data).forEach(x => {
            const msg = document.createTextNode(`${x.author}: ${x.content}\n`);
            messages.appendChild(msg);
        });

        author.value = '';
        content.value = '';

    }
}


attachEvents();