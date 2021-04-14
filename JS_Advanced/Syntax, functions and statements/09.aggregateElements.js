function solve(input) {


    function sumofArray(total, num) {
        return total + num;
    }


    function inverseSumofArray(input) {
        let result = 0;

        for (let i = 0; i < input.length; i++) {
            result += 1/input[i];
        }

        return result;
    }


    function concatArray(input) {
        let concat = '';

        for (let i = 0; i < input.length; i++) {
            concat += input[i];
        }

        return concat;
    }


    let totalSum = input.reduce(sumofArray);
    let inverseSum = inverseSumofArray(input);
    let concatResult = concatArray(input);



    console.log(totalSum);
    console.log(inverseSum);
    console.log(concatResult);
}

//--------different solution--------//

function solve(input) {

    function aggregate(arr, initVal, func) {

        let result = initVal;

        for (let i = 0; i < arr.length; i++) {
            result = func(result, arr[i]);
        }

        return result;
    }

    let sum = aggregate(input, 0, (a, b) => a + b);
    let inverseSum = aggregate(input, 0, (a, b) => a + 1/b);
    let concat = aggregate(input, '', (a, b) => a + b);

    console.log(sum);
    console.log(inverseSum);
    console.log(concat);

}

solve([1, 2, 3])
solve([2, 4, 8, 16])
