function solve(nums = []) {
    let sum = 0;
    const firstNum = Number(nums.shift());
    const lastNum = Number(nums.pop());
    sum = firstNum + lastNum;

    return sum;
}

console.log(solve(['20', '30', '40']))
console.log(solve(['5', '10']))


//--------//

function solve(nums = []) {
    return (+nums.shift()) + (+nums.pop());
}

console.log(solve(['20', '30', '40']))
console.log(solve(['5', '10']))