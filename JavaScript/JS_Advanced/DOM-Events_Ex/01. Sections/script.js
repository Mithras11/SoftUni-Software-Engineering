function create(words) {

    for (let word of words) {

        let divItem = document.createElement('div');

        let paragraphItem = document.createElement('p');
        paragraphItem.style.display = 'none';

        paragraphItem.textContent = word;

        divItem.appendChild(paragraphItem);


        divItem.addEventListener('click', onClick);

        document.getElementById('content').appendChild(divItem);


    }

    function onClick(ev) {
        ev.target.getElementsByTagName('p')[0].style.display = '';
    }
}

//------different approach------//


function create(words) {
    const output = document.getElementById('content');

    words.forEach(w => output.appendChild(createArticle(w)));

    function createArticle(text) {

        const pEl = createElement('p', text);
        pEl.style.display = 'none';

        const divEl = createElement('div', pEl);
        divEl.addEventListener('click', () => {
            pEl.style.display = '';
        });

        return divEl;
    }

    function createElement(type, content) {
        const result = document.createElement(type);

        if (typeof content == 'string') {
            result.textContent = content;
        } else {
            result.appendChild(content);
        }


        return result;
    }


}