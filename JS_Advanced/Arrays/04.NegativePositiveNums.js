function solve(arr = []) {
    let result = [];

    for (let num of arr) {
        num < 0 ? result.unshift(num) : result.push(num);
    }

    return result.join('\n');

}

console.log(solve([7, -2, 8, 9]));
console.log(solve([3, -2, 0, -1]));