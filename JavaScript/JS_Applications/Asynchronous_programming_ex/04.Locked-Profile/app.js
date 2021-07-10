async function lockedProfile() {

    const main = document.querySelector('main');
    main.innerHTML = '';

    try {

        const url = `http://localhost:3030/jsonstore/advanced/profiles`;

        const response = await fetch(url);
        const data = await response.json();

        let count = 1;

        Object.values(data).forEach(profile => {

            let div = createElement('div', 'profile', main);

            div.innerHTML += '<img src="./iconProfile2.png" class="userIcon" />';
            div.innerHTML += '<label>Lock</label>';
            div.innerHTML += `<input type="radio" name="user${count}Locked" value="lock" checked>`;
            div.innerHTML += '<label>Unlock</label>';
            div.innerHTML += `<input type="radio" name="user${count}Locked" value="unlock"><br>`;
            div.innerHTML += '<hr>';
            div.innerHTML += '<label>Username</label>';
            div.innerHTML += `<input type="text" name="user${count}Username" value="${profile.username}" disabled readonly />`;

            let hiddenFields = createElement('div', null, div);
            hiddenFields.setAttribute('id', `user${count}HiddenFields`);
            hiddenFields.style.display = 'none';

            hiddenFields.innerHTML += '<hr>';
            hiddenFields.innerHTML += '<label>Email:</label>';
            hiddenFields.innerHTML += `<input type="email" name="user${count}Email" value="${profile.email}" disabled readonly />`;
            hiddenFields.innerHTML += '<label>Age:</label>';
            hiddenFields.innerHTML += `<input type="email" name="user${count}Age" value="${profile.age}" disabled readonly />`;

            let button = createElement('button', null, div);
            button.textContent = 'Show more';

            count++;
        });

    } catch {

        throw new Error('Error with fetch');
    }


    let buttons = Array.from(document.getElementsByTagName('button'));
    buttons.forEach(btn => {
        btn.addEventListener('click', showOnClick);
    });

    function showOnClick(event) {

        let parentDiv = event.target.parentNode;
        let hiddenInfo = parentDiv.getElementsByTagName('div')[0];
        let lock = parentDiv.getElementsByTagName('input')[0];


        if (!lock.checked) {
            if (event.target.textContent === 'Show more') {

                hiddenInfo.style.display = 'inline';
                event.target.textContent = 'Hide it';

            } else {
                hiddenInfo.style.display = 'none';
                event.target.textContent = 'Show more';
            }

        }

    }




    function createElement(type, className, appender) {

        let result = document.createElement(type);

        if (className) {
            result.classList.add(className);
        }

        appender.appendChild(result);

        return result;
    }


};