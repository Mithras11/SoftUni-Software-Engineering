function solve(num1, num2) {
    let a = num1;
    let b = num2;
    let t = 0;

    while (b != 0) {
        t = b;
        b = a % b;
        a = t;
    }

    return a;
}

console.log(solve(15, 5))
console.log(solve(2154, 458))

//------recursively-----//

function gcd(num1, num2) {
    let x = num1;
    let y = num2;
  
    if (y) {
        return gcd(y, x % y);
    } else {
        return Math.abs(x);
    }
}

console.log(gcd(15,5))
console.log(gcd(2154, 458))