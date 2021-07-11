async function getRecipesList() {

    const main = document.querySelector('main');

    try {

        const url = 'http://localhost:3030/data/recipes?select=_id%2Cname%2Cimg';
        const response = await fetch(url);
        const recipes = await response.json();

        if (response.status == 404) {
            alert(response.status || response.statusText) //??
        }

        main.innerHTML = '';

        Object.values(recipes)
            .map(el => {
                const article = createElement('article', undefined, 'preview', main);

                const div = createElement('div', undefined, 'title', article);
                const h2 = createElement('h2', el.name, undefined, div);
                const div2 = createElement('div', undefined, 'small', article);
                const img = createElement('img', undefined, undefined, div2);

                img.setAttribute('src', el.img);

                article.addEventListener('click', () => getRecipesDetails(el._id, article));
            });


    } catch (error) {
        alert(error.message);
    }

}

async function getRecipesDetails(id, preview) {
    const url = `http://localhost:3030/data/recipes/${id}`;

    const response = await fetch(url);
    const details = await response.json();

    if (!response.ok) {
        alert(response.statusText || response.status);
    }

    const article = createElement('article');
    const h2 = createElement('h2', 'Title', undefined, article);

    h2.addEventListener('click', () => toggleCard());

    const div = createElement('div', undefined, 'band', article);
    const div2 = createElement('div', undefined, 'thumb', div);

    const img = createElement('img', undefined, undefined, div2);
    img.setAttribute('src', details.img);

    const div3 = createElement('div', undefined, 'ingredients', div);
    const h3 = createElement('h3', 'Ingredients', undefined, div3);

    const ul = createElement('ul', undefined, undefined, div3);

    Object.values(details.ingredients)
        .map(el => {
            const li = createElement('li', el, undefined, ul)
        });

    const div4 = createElement('div', undefined, 'description', article);
    const h3Prep = createElement('h3', 'Preparation', undefined, div4);

    Object.values(details.steps)
        .map(el => {
            createElement('p', el, undefined, div4)
        });

    preview.replaceWith(article);


    function toggleCard() {
        article.replaceWith(preview);
    }
}

function createElement(type, text, attributes, appender) {
    const result = document.createElement(type);

    if (text) {
        result.textContent = text;
    }

    if (attributes) {
        result.className = attributes;
    }

    if (appender) {
        appender.appendChild(result);
    }

    return result;
}

async function onClickLogout() {
    const token = sessionStorage.getItem('userToken');

    const response = await fetch('http://localhost:3030/users/logout', {
        method: 'get',
        headers: { 'X-Authorization': token }
    });

    if (!response.ok) {
        const error = await response.json();
        alert(error.message);
        return;
    }

    sessionStorage.removeItem('userToken');

    window.location.pathname = 'index.html'; //refresh home page

}


window.addEventListener('load', () => {
    const token = sessionStorage.getItem('userToken');

    if (token) {
        document.getElementById('user').style.display = 'inline-block';
        document.getElementById('logoutBtn').addEventListener('click', onClickLogout)

    } else {
        document.getElementById('guest').style.display = 'inline-block';
    }


    getRecipesList();
});