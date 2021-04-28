function townPopulation(args) {

    const towns = [];

    for (const arg of args) {

        let info = arg.split(' <-> ');
        let townName = info[0];
        let townPopulation = +info[1];

        if (towns.some(x => x.name === townName)) {
            towns.find(x => x.name === townName).population += townPopulation;
        } else {

            let town = {
                name: townName,
                population: townPopulation
            }

            towns.push(town);
        }
    }

    return towns.map(x => `${x.name} : ${x.population}`).join('\n');

}

console.log(townPopulation([
    'Sofia <-> 1200000',
    'Montana <-> 20000',
    'New York <-> 10000000',
    'Washington <-> 2345000',
    'Las Vegas <-> 1000000']));

console.log(townPopulation([
    'Istanbul <-> 100000',
    'Honk Kong <-> 2100004',
    'Jerusalem <-> 2352344',
    'Mexico City <-> 23401925',
    'Istanbul <-> 1000']));

//--------//

function townPopulation(input = []) {

    let towns = {};

    for (const arr of input) {

        let [name, population] = arr.split(' <-> ');
        population = +population;

        if (!towns.hasOwnProperty(name)) {
            towns[name] = 0;
        }
        towns[name] += population;
    }

    let output = '';
    Object.entries(towns).forEach(x => output += `${x[0]} : ${x[1]}\n`);
    return output.trim();


}
