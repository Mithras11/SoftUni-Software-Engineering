function solve(arr = []) {

    return arr.sort((a, b) => {

        if (a.length === b.length) {
            return a.localeCompare(b);
        }

        return (a.length - b.length)

    }).join('\n');

}

console.log(solve([
    'alpha',
    'beta',
    'gamma']));

console.log(solve([
    'Isacc',
    'Theodor',
    'Jack',
    'Harrison',
    'George']));

console.log(solve([
    'test',
    'Deny',
    'omen',
    'Default']));
