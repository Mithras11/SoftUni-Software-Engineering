async function solution() {
    const main = document.querySelector('#main');

    try {
        const url = `http://localhost:3030/jsonstore/advanced/articles/list`;
        const response = await fetch(url);
        const data = await response.json();

        data.forEach(item => {

            const parentDiv = createElement('div', 'accordion', null, main);
            const div = createElement('div', 'head', null, parentDiv);
            const span = createElement('span', null, `${item.title}`, div);
            const btn = createElement('button', 'button', 'More', div);

            btn.setAttribute('id', `${item._id}`);

        });

    } catch {

        throw new Error;
    }


    const buttons = Array.from(document.getElementsByTagName('button'));

    buttons.forEach(btn => {

        btn.addEventListener('click', getMoreInfo);
    });

    async function getMoreInfo(event) {

        let btn = event.target;
        let id = btn.getAttribute('id');
        let mainDiv = btn.parentNode.parentNode;
        let extraDiv;

        url = `http://localhost:3030/jsonstore/advanced/articles/details/${id}`;

        try {
            response = await fetch(url);
            data = await response.json();

            extraDiv = mainDiv.querySelector('.extra');

            if (btn.textContent === 'Less') {

                btn.textContent = 'More';
                extraDiv.style.display = 'none';

                return;
            }

            if (extraDiv) {

                btn.textContent = 'Less';
                extraDiv.style.display = 'block';

                return;
            }

            extraDiv = createElement('div', 'extra', null, mainDiv);

            mainDiv.appendChild(extraDiv);
            let p = createElement('p', null, data.content, extraDiv);

            btn.textContent = 'Less';
            extraDiv.style.display = 'block';



        } catch {

            throw new Error;
        }

    }


    function createElement(type, className, text, appender) {

        const result = document.createElement(type);

        if (className) {
            result.classList.add(className);
        }
        if (text) {
            result.textContent = text;
        }

        appender.appendChild(result);

        return result;

    }


}

solution();