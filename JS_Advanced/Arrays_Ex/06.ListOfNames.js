function solve(names = []) {
    names.sort((a, b) => a.localeCompare(b));

    let result = [];

    for (let i = 0; i < names.length; i++) {
        let currName = `${i + 1}.` + names[i];
        result.push(currName);

    }

    return result.join('\n');
}

console.log(solve(["John", "Bob", "Christina", "Ema"]));

//------//

function solve(names = []) {
    return names
        .sort((a, b) => a.localeCompare(b))
        .map((value, index) => value = `${index + 1}.${value}`)
        .join('\n');

}