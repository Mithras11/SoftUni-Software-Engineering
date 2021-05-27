function calc() {
    const num1 = +document.getElementById('num1').value;
    const num2 = +document.getElementById('num2').value;

    const result = num1 + num2;

    document.getElementById('sum').value = result;
}