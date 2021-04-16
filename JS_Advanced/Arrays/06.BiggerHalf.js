function solve(nums = []) {
    let arr = nums.sort((a, b) => a - b);
    const index = Math.floor(arr.length / 2);
    const res = arr.slice(index);
    return res;

}

console.log(solve([4, 7, 2, 5, 8]))

//-----///

function solve(nums = []) {
    let arr = nums.sort((a, b) => a - b);
    const index = arr.length / 2;
    return arr.slice(index);
    
}