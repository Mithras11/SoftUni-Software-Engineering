document.querySelector('form').addEventListener('submit', onLoginSubmit);

async function onLoginSubmit(event) {
    event.preventDefault(); //!!!

    const formData = new FormData(event.target);

    const email = formData.get('email');
    const password = formData.get('password');

    const response = await fetch('http://localhost:3030/users/login', {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ email, password })
    });

    if (!response.ok) {
        const error = await response.json();
        alert(error.message);
        return;
    }

    const data = await response.json();
    sessionStorage.setItem('userToken', data.accessToken);

    window.location.pathname = 'index.html'; //redirect back to home page
}