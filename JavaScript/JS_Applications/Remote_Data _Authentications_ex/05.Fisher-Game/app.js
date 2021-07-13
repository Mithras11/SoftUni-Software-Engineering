function attachEvents() {

    document.querySelector('.load').addEventListener('click', load);

    async function load(event) {
        event.preventDefault();

        const response = await fetch('http://localhost:3030/data/catches');

        if (!response.ok) {
            const error = await response.json();
            return alert(error.message);
        }

        const data = await response.json();

        console.log(data);
    }




    async function logout(event) {
        event.preventDefault();

        const token = sessionStorage.getItem('userToken');
        const id = sessionStorage.getItem('userId');

        const response = await fetch('http:localhost:3030/users/logout', {
            method: 'GET',
            headers: { 'X-Authorization': token }
        });

        if (!response.ok) {
            const error = await response.json();
            alert(error.message);
            return;
        }

        sessionStorage.removeItem('userToken');
        sessionStorage.removeItem('userId');

        event.target.textContent = 'Login';

        location.assign('./index.html');
    }


    window.addEventListener('load', () => {
        const token = sessionStorage.getItem('userToken');

        if (token) {
            const logoutBtn = document.querySelector('#guest [href="login.html"]');
            logoutBtn.textContent = 'Logout';
            logoutBtn.addEventListener('click', logout)
        }
    });


}

attachEvents();