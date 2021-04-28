function solve(num) {

    const x = num.toString();
    let areEqual = true;
    let totalSum = 0;

    for (let i = 0; i < x.length - 1; i++) {
        if (x[i] !== x[i + 1]) {
            areEqual = false;
        }
        totalSum += Number(x[i]);
    }

    totalSum += Number(x[x.length - 1]);

    return `${areEqual}\n${totalSum}`;

}

console.log(solve(2222222))
console.log(solve(1234))

//---------different solution-----//

function solve(num) {

    const string = num.toString();
    let areEqual = true;
    let totalSum = 0;

    for (let i = 0; i < string.length; i++) {

        let current = string[i];
        let next = string[i + 1];

        if (string[i] !== string[i + 1] && next !== undefined) {
            areEqual = false;
        }
        totalSum += Number(current);
    }

    return `${areEqual}\n${totalSum}`;

}

console.log(solve(2222222))
console.log(solve(1234))