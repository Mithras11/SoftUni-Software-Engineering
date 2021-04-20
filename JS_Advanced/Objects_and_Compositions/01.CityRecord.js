function object(cityName, cityPopulation, cityTreasury) {

    const city = {
        name: cityName,
        population: cityPopulation,
        treasury: cityTreasury
    }

    return city;
}


console.log(object(
    'Tortuga',
    7000,
    15000));

console.log(object(
    'Santo Domingo',
    12000,
    23500));