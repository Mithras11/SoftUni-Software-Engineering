function solve(input = []) {
    const arr = input;
    const result = [];

    for (let i = 0; i < arr.length; i += 2) {
        result.push(arr[i]);
    }

    return result.join(' ')


}

console.log(solve(['20', '30', '40', '50', '60']))
console.log(solve(['20', '30', '40', '50']))

//------- diff -----//

function solve(nums = []) {
    return nums.filter((_, index) => index % 2 === 0).join(' ')
}

console.log(solve(['20', '30', '40', '50', '60']))
console.log(solve(['20', '30', '40', '50']))
