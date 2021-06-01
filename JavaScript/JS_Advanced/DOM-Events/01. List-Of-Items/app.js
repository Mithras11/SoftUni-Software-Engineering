function addItem() {

    const input = document.getElementById('newItemText').value;
    const newElement = document.createElement('li');

    newElement.textContent = input;

    const list = document.getElementById('items');

    list.appendChild(newElement);

    document.getElementById('newItemText').value = '';
}