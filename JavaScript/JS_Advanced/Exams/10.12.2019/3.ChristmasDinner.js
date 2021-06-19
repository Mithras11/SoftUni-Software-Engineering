class ChristmasDinner {

    constructor(budget) {

        this.budget = budget;
        this.dishes = [];
        this.products = [];
        this.guests = {};
    }

    get budget() {
        return this._budget;
    }

    set budget(value) {
        if (value < 0) {
            throw new Error('The budget cannot be a negative number');
        };

        this._budget = value;
    }


    shopping(product) {
        let [type, price] = product;

        if (this.budget < price) {
            throw new Error('Not enough money to buy this product');
        };

        this.products.push(type);
        this.budget -= price;

        return `You have successfully bought ${type}!`;
    }


    recipes(recipe) {

        let { recipeName, productsList } = recipe; // string, arr of strings

        if (!productsList.every(p => this.products.indexOf(p) > -1)) {
            throw new Error('We do not have this product');
        };

        this.dishes.push({ recipeName, productsList });

        return `${recipeName} has been successfully cooked!`;

    }

    inviteGuests(name, dish) {
        if (!this.dishes.some(x => x.recipeName === dish)) {
            throw new Error('We do not have this dish');

        } else if (name in this.guests) {
            throw new Error('This guest has already been invited');

        } else {
            this.guests[name] = dish;

            return `You have successfully invited ${name}!`;
        }
    }

    showAttendance() {
        let result = '';

        let guestInfo = Object.entries(this.guests);

        for (const [name, dish] of guestInfo) {

            let products = this.dishes.find(x => x.recipeName === dish).productsList;


            result += `${name} will eat ${dish}, which consists of ${products.join(', ')}\n`;
        };

        return result.trim();



    }


}

let  dinner  =  new  ChristmasDinner(300);

dinner.shopping(['Salt', 1]);
dinner.shopping(['Beans', 3]);
dinner.shopping(['Cabbage', 4]);
dinner.shopping(['Rice', 2]);
dinner.shopping(['Savory', 1]);
dinner.shopping(['Peppers', 1]);
dinner.shopping(['Fruits', 40]);
dinner.shopping(['Honey', 10]);

dinner.recipes({
    recipeName: 'Oshav',
    productsList: ['Fruits', 'Honey']
});
dinner.recipes({
    recipeName: 'Folded cabbage leaves filled with rice',
    productsList: ['Cabbage', 'Rice', 'Salt', 'Savory']
});
dinner.recipes({
    recipeName: 'Peppers filled with beans',
    productsList: ['Beans', 'Peppers', 'Salt']
});

dinner.inviteGuests('Ivan', 'Oshav');
dinner.inviteGuests('Petar', 'Folded cabbage leaves filled with rice');
dinner.inviteGuests('Georgi', 'Peppers filled with beans');
console.log(dinner.showAttendance());