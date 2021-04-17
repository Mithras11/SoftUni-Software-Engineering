function solve(nums = []) {
    let arr = [];

    for (let i = 1; i < nums.length; i += 2) {
        let currNum = nums[i] * 2;
        arr.unshift(currNum);
    }

    return arr.join(' ');
}

console.log(solve([10, 15, 20, 25]))

//-------//

function solve(numbers = []) {
    return numbers.filter((_, index) => index % 2 !== 0).map(x => +x * 2).reverse().join(' ');
  }