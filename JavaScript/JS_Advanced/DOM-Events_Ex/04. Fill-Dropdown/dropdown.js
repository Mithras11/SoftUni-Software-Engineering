function addItem() {

    let newItemText = document.getElementById('newItemText');
    let newItemValue = document.getElementById('newItemValue');


    let newOptionELement = document.createElement('option');

    newOptionELement.textContent = newItemText.value;
    newOptionELement.value = newItemValue.value;

    document.getElementById('menu').appendChild(newOptionELement);

    newItemText.value = '';
    newItemValue.value = '';


}