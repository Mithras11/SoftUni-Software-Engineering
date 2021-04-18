function solve(arr = [], delimiter) {
    return arr.join(delimiter)
}

console.log(solve(['One',
    'Two',
    'Three',
    'Four',
    'Five'],
    '-'))

console.log(solve(['How about no?',
    'I',
    'will',
    'not',
    'do',
    'it!'],
    '_'))