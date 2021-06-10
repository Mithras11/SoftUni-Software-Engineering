function solve(...input) {

    const types = [];
    const result = [];

    input.forEach(x => {
        types.push({
            [typeof x]: x
        });

        result.push(`${typeof x}: ${x}`);
    });

    const counts = {};

    types.forEach(t => {
        let key = Object.keys(t)[0];

        !counts[key] ? counts[key] = 1 : counts[key]++;
    });

    Object.keys(counts)
        .sort((a, b) => counts[b] - counts[a])
        .forEach(k => result.push(`${k} = ${counts[k]}`));

    result.forEach(x => console.log(x));



}




solve('cat', 42, function() { console.log('Hello world!'); });
solve({ name: 'bob' }, 3.333, 9.999);