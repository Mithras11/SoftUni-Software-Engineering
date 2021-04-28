function solve(nums = [[]]) {
    let maxRow = nums.map(row => Math.max(...row));
    return max = Math.max(...maxRow);
}

console.log(solve(
    [[20, 50, 10],
    [8, 33, 145]]))

console.log(solve(
    [[3, 5, 7, 12],
    [-1, 4, 33, 2],
    [8, 3, 0, 4]]))

//------//

function solve(nums) {
    let arr = nums.flat();
    return Math.max(...arr);

}

//------//

function solve(nums) {
    let result = 0;

    for (let i = 0; i < nums.length; i++) {
        for (let j = 0; j < nums[i].lengthS; j++) {

            if (nums[i][j] > result) {
                result = nums[i][j];
            }
        }
    }

    return result;

}

