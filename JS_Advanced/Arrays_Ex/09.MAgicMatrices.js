function solve(matrix = [[]]) {
  
    let areRowsEqual = matrix.map(row => row.reduce((a, b) => a + b))
        .every((element, index, arr) => element === arr[0]);

    let areColsEqual = matrix.reduce((a, b) => a.map((element, index) => element + b[index]))
        .every((element, index, arr) => element === arr[0]);

    return areRowsEqual && areColsEqual;
}


console.log(solve([
    [4, 5, 6],
    [6, 5, 4],
    [5, 5, 5]]));

console.log(solve(
    [[11, 32, 45],
    [21, 0, 1],
    [21, 1, 1]]));

console.log(solve([
    [1, 0, 0],
    [0, 0, 1],
    [0, 1, 0]]));