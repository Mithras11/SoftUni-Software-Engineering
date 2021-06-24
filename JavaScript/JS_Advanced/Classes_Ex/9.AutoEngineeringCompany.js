function solve(arr) {

    let cars = {};

    arr.forEach(x => {
        let [brand, model, quantity] = x.split(' | ');

        if (!cars.hasOwnProperty(brand)) {
            cars[brand] = [];
        }

        let targetModel = cars[brand].find(x => x[model]);

        if (!targetModel) {
            cars[brand].push({
                [model]: +quantity
            });
        } else {

            targetModel[model] += +quantity;
        }

    });

    let result = '';

    for (const [brand, carData] of Object.entries(cars)) {

        result += `${brand}\n`;

        for (const item of carData) {

            let model = Object.keys(item);
            let quantity = item[model];

            result += `###${model} -> ${quantity}\n`;
        }

    }

    return result.trimEnd();
}






solve(['Audi | Q7 | 1000',
    'Audi | Q6 | 100',
    'BMW | X5 | 1000',
    'BMW | X6 | 100',
    'Citroen | C4 | 123',
    'Volga | GAZ-24 | 1000000',
    'Lada | Niva | 1000000',
    'Lada | Jigula | 1000000',
    'Citroen | C4 | 22',
    'Citroen | C5 | 10'
]);