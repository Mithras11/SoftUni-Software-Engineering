function subSum(arr, start, end) {

    if (!Array.isArray(arr)) {
        return NaN;
    }

    if (start < 0) {
        start = 0;
    }

    // if (end > arr.length - 1) {
    //     end = arr.length - 1;
    // }

    return arr.slice(start, end + 1).reduce((acc, val) => acc + Number(val), 0);

}

subSum([10, 20, 30, 40, 50, 60], 3, 300);
subSum([1.1, 2.2, 3.3, 4.4, 5.5], -3, 1);
subSum([10, 'twenty', 30, 40], 0, 2);
subSum([], 1, 2);
subSum('text', 0, 2);