function solve(products) {
    let result = [];

    for (let product of products) {
        let [name, price] = product.split(' : ');
        price = +price;

        let obj = {
            name,
            price
        };

        result.push(obj);
    }

    result = result.sort((a, b) => a.name.localeCompare(b.name));

    let msg = '';
    let currLetter = '';

    for (item of result) {
        if (item.name[0] != currLetter) {
            currLetter = item.name[0];
            msg += currLetter + '\n';
        }
        msg += `  ${item.name}: ${item.price}\n`;
    }

    return msg;
}


console.log(solve([
    'Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10']));

console.log(solve([
    'Banana : 2',
    'Rubic\'s Cube : 5',
    'Raspberry P : 4999',
    'Rolex : 100000',
    'Rollon : 10',
    'Rali Car : 2000000',
    'Pesho : 0.000001',
    'Barrel : 10']));