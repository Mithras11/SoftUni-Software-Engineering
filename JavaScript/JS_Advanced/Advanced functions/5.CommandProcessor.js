function solution() {

    let result = '';

    return {
        append,
        removeStart,
        removeEnd,
        print,
    };

    function append(str) {
        result += str;
    }

    function removeStart(n) {
        result = result.substring(n);
    }

    function removeEnd(n) {
        result = result.slice(0, -n);
    }

    function print() {
        console.log(result);
    }

}


let firstZeroTest = solution();

firstZeroTest.append('hello');
firstZeroTest.append('again');
firstZeroTest.removeStart(3);
firstZeroTest.removeEnd(4);
firstZeroTest.print();