function extract(id) {

    const text = document.getElementById(id).textContent;

    const regex = /\((.+?)\)/gm;

    let result = [];

    let match = regex.exec(text);

    while (match != null) {

        result.push(match[1]);

        match = regex.exec(text);
    }

    return result.join('; ');
}