document.querySelector('#register-form').addEventListener('submit', register);
document.querySelector('#login-form').addEventListener('submit', login);

const loginBtn = document.querySelector('#guest [href="login.html"]');
loginBtn.disabled = true;

async function register(event) {
    event.preventDefault();

    const dataForm = new FormData(event.target);

    const email = dataForm.get('email');
    const password = dataForm.get('password');
    const rePass = dataForm.get('rePass');

    if (email == '' || password == '') {
        return alert('All fields are required!');
    }

    if (password != rePass) {
        return alert('Passwords don\'t match!');
    }

    const response = await fetch('http://localhost:3030/users/register', {
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
    sessionStorage.setItem('userId', data._id);

    location.assign('./index.html'); //redirect back to home page
}


async function login(event) {
    event.preventDefault();

    const dataForm = new FormData(event.target);

    const email = dataForm.get('email');
    const password = dataForm.get('password');

    if (email == '' || password == '') {
        return alert('All fields are required!');
    }


    const response = await fetch('http://localhost:3030/users/login', {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ email, password })
    });

    if (!response.ok) {
        const error = await response.json();
        return alert(error.message);
    }

    const data = await response.json();
    sessionStorage.setItem('userToken', data.accessToken);
    sessionStorage.setItem('userId', data._id);

    location.assign('./index.html'); //redirect back to home page
}