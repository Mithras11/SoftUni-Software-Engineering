function add(num) {
    let sum = 0;
    sum += num;

    function calc(num) {

        sum += num;

        return calc;
    }

    calc.toString = () => sum;

    return calc;
}

console.log(+add(1)(2)(4));