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