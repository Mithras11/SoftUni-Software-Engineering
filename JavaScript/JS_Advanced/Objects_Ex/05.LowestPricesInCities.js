function solve(products) {

    const result = {};

    for (const product of products) {

        let [town, name, price] = product.split(' | ');
        price = +price;

        if (name in result == false) {

            result[name] = { town, price };

        } else if (result[name].price > price) {
            result[name].price = price;
            result[name].town = town;
        }
    }

    let msg = '';

    for (const key in result) {
        msg += `${key} -> ${result[key].price} (${result[key].town})` + '\n';
    };

    return msg.trim();
}

console.log(solve([
    'Sample Town | Sample Product | 1000',
    'Sample Town | Orange | 2',
    'Sample Town | Peach | 1',
    'Sofia | Orange | 1',
    'Sofia | Peach | 2',
    'New York | Sample Product | 1000.1',
    'New York | Burger | 10']));

console.log(solve([
    'Sofia City | Audi | 100000',
    'Sofia City | BMW | 100000',
    'Sofia City | Mitsubishi | 10000',
    'Sofia City | Mercedes | 10000',
    'Sofia City | NoOffenseToCarLovers | 0',
    'Mexico City | Audi | 1000',
    'Mexico City | BMW | 99999',
    'New York City | Mitsubishi | 10000',
    'New York City | Mitsubishi | 1000',
    'Mexico City | Audi | 100000',
    'Washington City | Mercedes | 1000']));