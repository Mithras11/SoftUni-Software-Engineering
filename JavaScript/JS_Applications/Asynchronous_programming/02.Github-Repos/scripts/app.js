function loadRepos() {
    const username = document.getElementById('username').value;

    const url = `https://api.github.com/users/${username}/repos`;

    fetch(url)
        .then((response) => {
            if (response.status == 404) {
                throw new Error('User not found');
            }

            return response.json();
        })
        .then((data) => {
            const ul = document.querySelector('#repos');

            ul.innerHTML = '';

            data.forEach(d => {
                const a = document.createElement('a');
                const li = document.createElement('li');

                a.setAttribute('href', d.html_url);
                a.textContent = d.full_name;

                li.appendChild(a);
                ul.appendChild(li);
            })
        })
        .catch(error => {
            alert(error.message);
        });
}

// async version //

async function loadRepos() {
    const username = document.getElementById('username').value;

    const url = `https://api.github.com/users/${username}/repos`;

    try {

        const response = await fetch(url);

        if (response.status == 404) {
            throw new Error('User not found');
        }

        const data = await response.json();

        const ul = document.querySelector('#repos');

        ul.innerHTML = '';

        data.forEach(d => {
            const a = document.createElement('a');
            const li = document.createElement('li');

            a.setAttribute('href', d.html_url);
            a.textContent = d.full_name;

            li.appendChild(a);
            ul.appendChild(li);
        })

    } catch (error) {
        alert(error.message);
    };
}