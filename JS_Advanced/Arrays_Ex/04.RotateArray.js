function solve(arr = [], count) {

    let element = 0;

    for (let i = 0; i < count; i++) {
        element = arr.pop();
        arr.unshift(element);
    }

    return arr.join(' ');
}

console.log(solve(['1',
    '2',
    '3',
    '4'],
    2));

console.log(solve(['Banana', 
'Orange', 
'Coconut', 
'Apple'], 
15));

