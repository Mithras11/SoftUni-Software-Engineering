function extractText() {
    const liElements = document.getElementsByTagName('li');
    const text = [...liElements].map(e => e.textContent);
    const textArea = document.getElementById('result');
    textArea.value = text.join('\n');
}