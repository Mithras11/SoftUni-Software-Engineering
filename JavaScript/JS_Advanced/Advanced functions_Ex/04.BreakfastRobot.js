function solution() {

    const library = {
        apple: { carbohydrate: 1, flavour: 2, },
        lemonade: { carbohydrate: 10, flavour: 20, },
        burger: { carbohydrate: 5, fat: 7, flavour: 3, },
        eggs: { protein: 5, fat: 1, flavour: 1, },
        turkey: { protein: 10, carbohydrate: 10, fat: 10, flavour: 10, }
    };

    let stock = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0,
    };

    let message = '';

    let robot = {
        restock: (microelement, quantity) => {

            stock[microelement] += Number(quantity);
            message = 'Success';

        },
        prepare: (recipe, quantity) => {
            let isEnough = true;

            Object.entries(library[recipe])
                .forEach(entry => {

                    let [microelement, count] = entry;
                    if (isEnough && stock[microelement] < count * Number(quantity)) {

                        message = `Error: not enough ${microelement} in stock`;
                        isEnough = false;
                    }
                });

            if (isEnough) {

                Object.entries(library[recipe])
                    .forEach(entry => {
                        let [microelement, count] = entry;

                        stock[microelement] -= count * Number(quantity);

                    });

                message = 'Success';

            }

        },
        report: () => {

            // message = '';

            // Object.entries(stock).forEach(entry => {

            //     let [key, value] = entry;
            //     message += `${key}=${value} `;
            // })

            message = `protein=${stock.protein} carbohydrate=${stock.carbohydrate} fat=${stock.fat} flavour=${stock.flavour}`

        },
    }



    return function manage(input) {
        let [command, ...args] = input.split(' ');
        robot[command](...args);

        return message;
    }



}

let manager = solution(); 
// console.log(manager("restock flavour 50"));  // Success 
// console.log(manager("prepare lemonade 4"));  // Error: not enough carbohydrate in stock 

console.log(manager('restock carbohydrate 10'));
console.log(manager('restock flavour 10'));
console.log(manager('prepare apple 1'));
console.log(manager('restock fat 10'));
console.log(manager('prepare burger 1'));
console.log(manager('report'));

// console.log(manager('prepare turkey 1'));
// console.log(manager('restock protein 10'));
// console.log(manager('prepare turkey 1'));
// console.log(manager('restock carbohydrate 10'));
// console.log(manager('prepare turkey 1'));
// console.log(manager('restock fat 10'));
// console.log(manager('prepare turkey 1'));
// console.log(manager('restock flavour 10'));
// console.log(manager('prepare turkey 1'));
// console.log(manager('report'));