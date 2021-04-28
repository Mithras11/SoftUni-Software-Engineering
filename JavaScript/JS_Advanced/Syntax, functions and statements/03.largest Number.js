function largestNum(num1, num2, num3) {
    let result;

    if (num1 > num2 && num1 > num3) {
        result = num1;
    }
    else if (num2 > num1 && num2 > num3) {
        result = num2;
    }
    else if (num3 > num1 && num3 > num2) {
        result = num3;
    }

    console.log(`The largest number is ${result}.`);
}

//--------other solution----------//

function largestNum(...params){
    console.log(Math.max(...params));
}



largestNum(-3, -5, -22.5);
largestNum(5, -3, 16);