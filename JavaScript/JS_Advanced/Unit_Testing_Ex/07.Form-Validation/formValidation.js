function validate() {

    document.querySelector("#submit").type = "button"; //Защо по дяволите???

    const btn = document.querySelector('#submit');
    const checkbox = document.querySelector('#company')
    let div = document.getElementById('valid');

    let isValid = true;

    btn.addEventListener('click', onClick);
    checkbox.addEventListener('change', onChange);

    function onClick(event) {

        let username = document.querySelector('#username').value;
        validateUsername(username);

        let email = document.getElementById('email').value;
        validateEmail(email);

        let password = document.getElementById('password').value;
        let confirmPassword = document.getElementById('confirm-password').value;
        validatePasswords(password, confirmPassword);

        let companyNumber = document.getElementById('companyNumber').value;
        validateCompanyNumber(Number(companyNumber));




        if (isValid) {
            div.style.display = 'block';

        } else {
            div.style.display = 'none';
        };
    };

    function onChange(event) {
        let companyInfo = document.getElementById('companyInfo');

        if (event.target.checked) {
            companyInfo.style.display = 'block';
        } else {
            companyInfo.style.display = 'none';
        }
    }


    function validateUsername(username) {

        let regexName = /^[A-Za-z0-9]{3,20}$/;

        if (!regexName.test(username)) {

            document.getElementById('username').style.borderColor = 'red';
            isValid = false;

        } else {
            document.getElementById('username').style.borderColor = '';
        }

    }

    function validateEmail(email) {

        let regEmail = /^[^@.]+@[^@]*\.[^@]*$/;

        if (!regEmail.test(email)) {

            document.getElementById('email').style.borderColor = 'red';
            isValid = false;
        } else {
            document.getElementById('email').style.borderColor = '';
        }
    }


    function validatePasswords(password, confirmPassword) {

        let regPassword = /^[A-Za-z0-9\_]{5,15}$/;

        if (!regPassword.test(password)) {

            document.getElementById('password').style.borderColor = 'red';
            isValid = false;

        } else {
            document.getElementById('password').style.borderColor = '';
        }



        if (!regPassword.test(confirmPassword)) {

            document.getElementById('confirm-password').style.borderColor = 'red';
            isValid = false;

        } else {
            document.getElementById('confirm-password').style.borderColor = '';
        }

        if (password !== confirmPassword) {

            document.getElementById('password').style.borderColor = 'red';
            document.getElementById('confirm-password').style.borderColor = 'red';
            isValid = false;
        };
    }

    function validateCompanyNumber(companyNumber) {
        if (checkbox.checked) {

            if (Number.isInteger(companyNumber) &&
                companyNumber >= 1000 &&
                companyNumber <= 9999) {

                document.getElementById('companyNumber').style.borderColor = '';

            } else {
                document.getElementById('companyNumber').style.borderColor = 'red';
                isValid = false;
            };

        };
    }
}