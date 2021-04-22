function solve(table) {

    const result = [];

    for (let i = 1; i < table.length; i++) {
        let [_,Town, Latitude, Longitude] = table[i].split(/\s*\|\s*/);

        Latitude = +(Number(Latitude).toFixed(2));
        Longitude = +(Number(Longitude).toFixed(2));


        let obj = {
            Town,
            Latitude,
            Longitude
        };

        result.push(obj);

    }

    return JSON.stringify(result);

}

console.log(solve([
    '| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |']));

console.log(solve([
    '| Town | Latitude | Longitude |',
    '| Veliko Turnovo | 43.0757 | 25.6172 |',
    '| Monatevideo | 34.50 | 56.11 |']));