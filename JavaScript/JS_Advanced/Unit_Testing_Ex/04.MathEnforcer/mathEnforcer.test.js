const mathEnforcer = require('./mathEnforcer');
const { expect } = require('chai');

describe('MathEnforcer', () => {
    describe('addFive', () => {
        it('returns undefined with invalid input', () => {
            expect(mathEnforcer.addFive('one')).to.be.undefined;
        });

        it('adds five to valid argument and returns result', () => {
            expect(mathEnforcer.addFive(1)).to.equal(6);
        });

        it('adds five to negative argument and returns result', () => {
            expect(mathEnforcer.addFive(-1)).to.equal(4);
        });

        it('adds five to floating-point argument and returns result', () => {
            expect(mathEnforcer.addFive(1.1)).to.be.closeTo(6.1, 0.00001);
        });

        it('adds five to negative floating-point argument and returns result', () => {
            expect(mathEnforcer.addFive(-1.1)).to.be.closeTo(3.9, 0.00001);
        });
    });

    describe('subtractSeven', () => {
        it('returns undefined with invalid input', () => {
            expect(mathEnforcer.subtractTen('one')).to.be.undefined;
        });

        it('subtracts ten from valid argument and returns result', () => {
            expect(mathEnforcer.subtractTen(11)).to.equal(1);
        });

        it('subtracts ten from negative argument and returns result', () => {
            expect(mathEnforcer.subtractTen(-1)).to.equal(-11);
        });

        it('subtracts ten from floating-point argument and returns result', () => {
            expect(mathEnforcer.subtractTen(12.1)).to.be.closeTo(2.1, 0.00001);
        });

        it('subtracts ten from negative floating-point argument and returns result', () => {
            expect(mathEnforcer.subtractTen(-1.1)).to.be.closeTo(-11.1, 0.00001);
        });
    });

    describe('sum', () => {
        it('returns undefined with invalid first parameter', () => {
            expect(mathEnforcer.sum('one', 1)).to.be.undefined;
        });

        it('returns undefined with invalid second parameter', () => {
            expect(mathEnforcer.sum(1, 'one')).to.be.undefined;
        });

        it('returns undefined with invalid  parameters', () => {
            expect(mathEnforcer.sum('zero', 'one')).to.be.undefined;
        });

        it('sums valid integer parameters', () => {
            expect(mathEnforcer.sum(1, 1)).to.equal(2);
        });

        it('sums  floating-point number with integer', () => {
            expect(mathEnforcer.sum(1.2, 1)).to.equal(2.2);
        });

        it('sums integer with floating-point number', () => {
            expect(mathEnforcer.sum(1, 1.2)).to.equal(2.2);
        });

        it('sums integer with negative number', () => {
            expect(mathEnforcer.sum(2, -1)).to.equal(1);
        });

        it('sums negative number with integer', () => {
            expect(mathEnforcer.sum(-2, 1)).to.equal(-1);
        });

        it('sums negative numbers', () => {
            expect(mathEnforcer.sum(-2, -1)).to.equal(-3);
        });
    });
})