window.addEventListener('load', solution);

function solution() {

    const fullName = document.querySelector('#fname');
    const email = document.querySelector('#email');
    const phoneNumber = document.querySelector('#phone');
    const address = document.querySelector('#address');
    const postalCode = document.querySelector('#code');

    const submitBtn = document.querySelector('#submitBTN');
    //submitBtn.setAttribute('disabled');
    const continueBtn = document.querySelector('#continueBTN');
    const editBtn = document.querySelector('#editBTN');

    //console.log(editBtn);

    const infoPreview = document.querySelector('#infoPreview');
    const blockDiv = document.querySelector('#block');



    let liFullName;
    let liEmail;
    let liPhone;
    let liAddress;
    let liCode;

    submitBtn.addEventListener('click', (event) => {
        event.preventDefault();

        if (fullName.value != '' && email.value != '') {

            liFullName = document.createElement('li');
            liFullName.textContent = 'Full Name: ' + fullName.value;
            infoPreview.appendChild(liFullName);
            fullName.value = '';

            liEmail = document.createElement('li');
            liEmail.textContent = 'Email: ' + email.value;
            infoPreview.appendChild(liEmail);
            email.value = '';

            liPhone = document.createElement('li');
            liPhone.textContent = 'Phone Number: ' + phoneNumber.value;
            infoPreview.appendChild(liPhone);
            phoneNumber.value = '';

            liAddress = document.createElement('li');
            liAddress.textContent = 'Address: ' + address.value;
            infoPreview.appendChild(liAddress);
            address.value = '';

            liCode = document.createElement('li');
            liCode.textContent = 'Postal Code: ' + postalCode.value;
            infoPreview.appendChild(liCode);
            postalCode.value = '';

            editBtn.disabled = false;
            continueBtn.disabled = false;
            submitBtn.disabled = true;
        }
    });


    editBtn.addEventListener('click', (event) => {
        event.preventDefault(); //???

        fullName.value = (liFullName.textContent).slice(11);
        liFullName.remove();

        email.value = (liEmail.textContent).slice(6);
        liEmail.remove();

        phoneNumber.value = (liPhone.textContent).slice(14);
        liPhone.remove();

        address.value = (liAddress.textContent).slice(9);
        liAddress.remove();

        postalCode.value = (liCode.textContent).slice(13);
        liCode.remove();

        editBtn.disabled = true;
        continueBtn.disabled = true;
        submitBtn.disabled = false;

    });


    continueBtn.addEventListener('click', (event) => {
        event.preventDefault();

        blockDiv.innerHTML = '';

        let h3Element = document.createElement('h3');
        h3Element.textContent = 'Thank you for your reservation!';

        blockDiv.appendChild(h3Element);
    })



}