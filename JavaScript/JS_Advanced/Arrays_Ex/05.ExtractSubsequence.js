function solve(arr = []) {

    return arr.reduce((acc, value) => {
        if (acc.length === 0 || acc[acc.length - 1] <= value) {
            acc.push(value);
        }
        return acc;
    },[]);
    
}

console.log(solve([1,
    3,
    8,
    4,
    10,
    12,
    3,
    2,
    24]));