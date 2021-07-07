async function loadCommits() {

    const username = document.querySelector('#username').value;
    const repository = document.querySelector('#repo').value;

    const url = `https://api.github.com/repos/${username}/${repository}/commits`;

    const ul = document.querySelector('#commits');
    ul.innerHTML = '';

    try {
        const response = await fetch(url);

        if (response.status === 404) {
            throw new Error(`${response.status} (${response.statusText})`);
        }

        const data = await response.json();

        data.forEach(d => {
            let li = document.createElement('li');
            li.textContent = `${d.commit.author.name}: ${d.commit.message}`;

            ul.appendChild(li);

        });
    } catch (error) {

        let li = document.createElement('li');
        li.textContent = `${error.message}`;

        ul.appendChild(li);
    }

}