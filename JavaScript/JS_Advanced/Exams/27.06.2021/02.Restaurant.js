class Restaurant {
    constructor(budget) {
        this.budgetMoney = budget;
        this.menu = {};
        this.stockProducts = {};
        this.history = [];
    }

    loadProducts(arr) {
        for (const product of arr) {
            let [productName, productQuantity, totalPrice] = product.split(' ');

            if (totalPrice > this.budgetMoney) {
                this.history.push(`There was not enough money to load ${productQuantity} ${productName}`);

            } else {

                let currProduct = this.stockProducts[productName];

                if (currProduct === undefined) {
                    this.stockProducts[productName] = { productQuantity, totalPrice };
                } else {
                    this.stockProducts[productName].productQuantity += Number(productQuantity);
                }

                this.budgetMoney -= Number(totalPrice);

                this.history.push(`Successfully loaded ${productQuantity} ${productName}`);
            }
        }

        //console.log(this.budget);
        return this.history.join('\n');
    }

    addToMenu(meal, neededArr, price) {

        if (this.menu.hasOwnProperty(meal)) {
            return `The ${meal} is already in our menu, try something different.`;

        } else {

            let neededProducts = neededArr.reduce((acc, val) => {
                let [productName, productQuantity] = val.split(' ');

                acc.push({ productName, productQuantity });

                return acc;
            }, []);

            this.menu[meal] = { neededProducts, price: Number(price) };


            let count = (Object.keys(this.menu)).length;

            if (count === 1) {
                return `Great idea! Now with the ${meal} we have 1 meal in the menu, other ideas?`;

            } else {

                //console.log(this.menu);
                return `Great idea! Now with the ${meal} we have ${count} meals in the menu, other ideas?`;

            }


        }
    }


    showTheMenu() {

        let count = (Object.keys(this.menu)).length;

        if (count === 0) {
            return 'Our menu is not ready yet, please come later...';

        } else {

            let msg = '';

            for (const meal of Object.keys(this.menu)) {

                msg += `${meal} - $ ${this.menu[meal].price}\n`;
            }

            return msg.trimEnd();

        }
    }

    makeTheOrder(meal) {
        let target = this.menu[meal];

        if (target === undefined) {
            return `There is not ${meal} yet in our menu, do you want to order something else?`;

        } else {

            let targetProducts = target.neededProducts;

            for (const currProduct of targetProducts) {
                if (!this.stockProducts[(currProduct.productName)]) {
                    return `For the time being, we cannot complete your order (${meal}), we are very sorry...`;
                }

                if (this.stockProducts[(currProduct.productName)].productQuantity < Number(currProduct.productQuantity)) {
                    return `For the time being, we cannot complete your order (${meal}), we are very sorry...`; //???
                }


            }

            for (const currProduct of targetProducts) {

                this.stockProducts[(currProduct.productName)].productQuantity -= Number(currProduct.productQuantity);
            }

            this.budgetMoney += target.price




            return `Your order (${meal}) will be completed in the next 30 minutes and will cost you ${target.price}.`;
        }
    }

}





// let kitchen = new Restaurant(1000);
// console.log(kitchen.loadProducts(['Banana 10 5', 'Banana 20 10', 'Strawberries 50 30', 'Yogurt 10 10', 'Yogurt 500 1500', 'Honey 5 50']));

// // let kitchen = new Restaurant(1000);
// console.log(kitchen.addToMenu('frozenYogurt', ['Yogurt 1', 'Honey 1', 'Banana 1', 'Strawberries 10'], 9.99));
// console.log(kitchen.addToMenu('Pizza', ['Flour 0.5', 'Oil 0.2', 'Yeast 0.5', 'Salt 0.1', 'Sugar 0.1', 'Tomato sauce 0.5', 'Pepperoni 1', 'Cheese 1.5'], 15.55));

// console.log(kitchen.showTheMenu());

let kitchen = new Restaurant(1000);
kitchen.loadProducts(['Yogurt 30 3', 'Honey 50 4', 'Strawberries 20 10', 'Banana 5 1']);
kitchen.addToMenu('frozenYogurt', ['Yogurt 1', 'Honey 1', 'Banana 1', 'Strawberries 10'], 9.99);
console.log(kitchen.makeTheOrder('frozenYogurt'));