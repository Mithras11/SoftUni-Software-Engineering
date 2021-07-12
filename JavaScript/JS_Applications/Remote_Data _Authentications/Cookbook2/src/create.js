document.querySelector('form').addEventListener('submit', onSubmitCreate);

async function onSubmitCreate(event) {
    event.preventDefault();

    const formData = new FormData(event.target);

    const name = formData.get('name');
    const img = formData.get('img');

    const ingredients = formData
        .get('ingredients')
        .split('\n')
        .map(x => x.trim())
        .filter(x => x != '');

    const steps = formData
        .get('steps')
        .split('\n')
        .map(x => x.trim())
        .filter(x => x != '');

    const token = sessionStorage.getItem('userToken');

    const response = await fetch('http://localhost:3030/data/recipes', {
        method: 'post',
        headers: {
            'Content-Type': 'application/json',
            'X-Authorization': token
        },
        body: JSON.stringify({ name, img, ingredients, steps })
    });

    if (!response.ok) {
        const error = response.json();
        alert(error.message);
        return;
    }

    window.location.pathname = 'index.html';
}