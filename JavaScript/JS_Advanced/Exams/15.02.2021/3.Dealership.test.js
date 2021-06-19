const dealership = require('./3.Dealership');
const { assert, expect } = require('chai');

describe('dealership', () => {
    describe('newCarCost', () => {
        it('gives discount when old model is on the list', () => {
            expect(dealership.newCarCost('Audi A4 B8', 20000)).to.equal(5000);
            expect(dealership.newCarCost('Audi A6 4K', 30000)).to.equal(10000);
            expect(dealership.newCarCost('Audi A8 D5', 35000)).to.equal(10000);
            expect(dealership.newCarCost('Audi TT 8J', 20000)).to.equal(6000);
        });

        it('gives no discount for invalid model', () => {
            expect(dealership.newCarCost('Audi A4 B9', 20000)).to.equal(20000);
        })
    });

    describe('carEquipment', () => {
        it('returns selected extras', () => {
            expect(dealership.carEquipment(['heated seats', 'sliding roof'], [0])).to.eql(['heated seats']);
            expect(dealership.carEquipment(['sliding roof', 'sport rims', 'navigation'], [0, 2])).to.eql(['sliding roof', 'navigation']);
        });

        it('returns undefined when invalid indexes are given', () => {
            expect(dealership.carEquipment(['heated seats', 'sliding roof'], [2])).to.eql([undefined]);
        });
    });

    describe('euroCategory', () => {

        it('gives discount depending on car category', () => {
            assert.equal(dealership.euroCategory(4),
                `We have added 5% discount to the final price: 14250.`);

            assert.equal(dealership.euroCategory(5),
                `We have added 5% discount to the final price: 14250.`)
        });

        it('gives no discount for low category', () => {
            assert.equal(dealership.euroCategory(3),
                'Your euro category is low, so there is no discount from the final price!');
        });

    });
});