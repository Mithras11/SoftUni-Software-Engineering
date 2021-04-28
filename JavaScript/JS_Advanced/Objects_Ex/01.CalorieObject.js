function solve(arr) {
    const obj = {};

    for (let i = 0; i < arr.length; i++) {
        obj[arr[i]] = +arr[++i];
    }

    return obj;
}

console.log(solve(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']));
console.log(solve(['Potato', '93', 'Skyr', '63', 'Cucumber', '18', 'Milk', '42']));



