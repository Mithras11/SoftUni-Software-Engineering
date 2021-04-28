function solve(num, o1, o2, o3, o4, o5) {

    let number = Number(num);
    const operations = [o1, o2, o3, o4, o5];
    let result = []

    for (let i = 0; i < operations.length; i++) {
        const currentOpration = operations[i];

        switch (currentOpration) {
            case "chop": num /= 2; break;
            case "dice": num = Math.sqrt(num); break;
            case "spice": num++; break;
            case "bake": num *= 3; break;
            case "fillet": num = (num * 0.8).toFixed(1); break;
        }

        result.push(num);
    }

    return result.join('\n');

}

console.log(solve('9', 'dice', 'spice', 'chop', 'bake', 'fillet'))
console.log(solve('32', 'chop', 'chop', 'chop', 'chop', 'chop'))

//------- different version------//

function solve(...params) {

    let num = +params.shift();

    let operations = {
        chop: (num) => num / 2,
        dice: (num) => Math.sqrt(num),
        spice: (num) => ++num,
        bake: (num) => num *= 3,
        fillet: (num) => +(num *= 0.8).toFixed(1)
    }

    for (let i = 0; i < params.length; i++) {

        num = operations[params[i]](num);
        console.log(num);

    }
}



solve('32', 'chop', 'chop', 'chop', 'chop', 'chop');
solve('9', 'dice', 'spice', 'chop', 'bake', 'fillet');