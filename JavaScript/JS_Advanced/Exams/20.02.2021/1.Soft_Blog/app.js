function solve() {

    const btnCreate = document.querySelector('.create');

    btnCreate.addEventListener('click', onClickGenerate);

    function onClickGenerate(event) {

        event.preventDefault(); //BullShit!!!!

        const creator = document.querySelector('#creator').value;
        const title = document.querySelector('#title').value;
        const category = document.querySelector('#category').value;
        const content = document.querySelector('#content').value;

        const article = document.createElement('article');

        const header = document.createElement('h1');
        header.textContent = title;
        article.appendChild(header);

        const pCategory = document.createElement('p');
        pCategory.innerHTML = `Category: <strong>${category}</strong>`;
        article.appendChild(pCategory);

        const pCreator = document.createElement('p');
        pCreator.innerHTML = `Creator: <strong>${creator}</strong>`;
        article.appendChild(pCreator);

        const pContent = document.createElement('p');
        pContent.textContent = content;
        article.appendChild(pContent);


        const buttonsDiv = document.createElement('div');
        buttonsDiv.classList.add('buttons');

        const deleteBtn = document.createElement('button');
        deleteBtn.classList.add('btn');
        deleteBtn.classList.add('delete');
        deleteBtn.textContent = 'Delete';
        deleteBtn.addEventListener('click', onClickDelete);
        buttonsDiv.appendChild(deleteBtn);

        const archiveBtn = document.createElement('button');
        archiveBtn.classList.add('btn');
        archiveBtn.classList.add('archive');
        archiveBtn.textContent = 'Archive';
        archiveBtn.addEventListener('click', onClickArchive);
        buttonsDiv.appendChild(archiveBtn);

        article.appendChild(buttonsDiv);

        const section = document.querySelector('main>section');

        section.appendChild(article);


    }


    function onClickDelete(event) {
        event.target.parentNode.parentNode.remove();
    }

    function onClickArchive(event) {

        const liItem = document.createElement('li');

        const content = (event.target.parentNode.parentNode)
            .getElementsByTagName('h1')[0].textContent;

        liItem.textContent = content;

        event.target.parentNode.parentNode.remove();

        const archive = document.querySelector('.archive-section>ol');
        archive.appendChild(liItem);

        let ol = document.getElementsByTagName('ol')[0];
        Array.from(ol.getElementsByTagName("li"))
            .sort((a, b) => a.textContent.localeCompare(b.textContent))
            .forEach(li => ol.appendChild(li));

    }





}