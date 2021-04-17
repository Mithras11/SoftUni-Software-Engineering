function solve(arr = [], start, end) {
    const x = arr.indexOf(start);
    const y = arr.indexOf(end);

    return arr.slice(x,y+1);
}

console.log(solve(['Pumpkin Pie',
'Key Lime Pie',
'Cherry Pie',
'Lemon Meringue Pie',
'Sugar Cream Pie'],
'Key Lime Pie',
'Lemon Meringue Pie'))