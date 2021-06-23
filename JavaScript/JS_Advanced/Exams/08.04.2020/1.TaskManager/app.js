function solve() {
    // const task = document.querySelector('#task').value;
    // const description = document.querySelector('#description').value;
    // const dueDate = document.querySelector('#date').value;

    const addBtn = document.querySelector('#add');
    addBtn.addEventListener('click', onClickAdd);

    const openSection = document.querySelector('.orange').parentNode.parentNode.children[1];
    //const openSection = document.querySelector('section:nth-child(2) > div:nth-child(2)');
    //const openSection = document.querySelector('body > main > div > section:nth-child(2) > div:nth-child(2)');

    const inProgressSection = document.querySelector('#in-progress');

    const completeSection = document.querySelector('.green').parentNode.parentNode.children[1];
    //const completeSection = document.querySelector('section:nth-child(4) > div:nth-child(2)');
    //const completeSection = document.querySelector('body > main > div > section:nth-child(4) > div:nth-child(2)');



    function onClickAdd(event) {

        event.preventDefault();


        const task = document.querySelector('#task').value;
        const description = document.querySelector('#description').value;
        const dueDate = document.querySelector('#date').value;

        if (task && description && dueDate) {

            const newArticle = document.createElement('article');

            const h3Tag = document.createElement('h3');
            h3Tag.textContent = task;
            newArticle.appendChild(h3Tag);

            const pElement1 = document.createElement('p');
            pElement1.textContent = 'Description: ' + description;
            newArticle.appendChild(pElement1);

            const pElement2 = document.createElement('p');
            pElement2.textContent = 'Due Date: ' + dueDate;
            newArticle.appendChild(pElement2);

            const div = document.createElement('div');
            div.classList.add('flex');
            newArticle.appendChild(div);

            openSection.appendChild(newArticle);


            const startBtn = document.createElement('button');
            startBtn.classList.add('green');
            startBtn.textContent = 'Start';
            div.appendChild(startBtn);

            const deleteBtn = document.createElement('button');
            deleteBtn.classList.add('red');
            deleteBtn.textContent = 'Delete';
            div.appendChild(deleteBtn);



            const finishBtn = document.createElement('button');
            finishBtn.classList.add('orange');
            finishBtn.textContent = 'Finish';


            startBtn.addEventListener('click', () => {

                startBtn.remove();
                div.appendChild(finishBtn);

                inProgressSection.appendChild(newArticle);

            });

            deleteBtn.addEventListener('click', () => {
                newArticle.remove();
            });

            finishBtn.addEventListener('click', () => {
                div.remove();

                completeSection.appendChild(newArticle);

            });



        }


    }


}