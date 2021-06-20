const pizzUni = require('./pizza');
const assert = require('chai').assert;
const expect = require('chai').expect;

describe('Pizza', () => {
    it('takes orders', () => {
        let emptyObj = { undefined };
        expect(function() { pizzUni.makeAnOrder(emptyObj) }).to.throw();

        let obj1 = { orderedPizza: 'Margherita' };
        assert.equal(pizzUni.makeAnOrder(obj1),
            'You just ordered Margherita');

        let obj2 = { orderedPizza: 'Margherita', orderedDrink: 'Soda' };
        assert.equal(pizzUni.makeAnOrder(obj2),
            'You just ordered Margherita and Soda.');

    });

    it('checks status', () => {
        let arr1 = [{ pizzaName: 'Margherita', status: 'ready' }];
        assert.equal(pizzUni.getRemainingWork(arr1),
            'All orders are complete!');

        let arr2 = [{ pizzaName: 'Margherita', status: 'ready' },
            { pizzaName: 'Verdi', status: 'preparing' }
        ];

        assert.equal(pizzUni.getRemainingWork(arr2),
            'The following pizzas are still preparing: Verdi.')
    });

    it('check type of order', () => {
        assert.equal(pizzUni.orderType(100, 'Carry Out'),
            90);

        assert.equal(pizzUni.orderType(100, 'Delivery'),
            100);
    })
});