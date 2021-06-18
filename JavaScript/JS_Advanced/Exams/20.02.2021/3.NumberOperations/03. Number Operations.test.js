const numberOperations = require('./03. Number Operations');
const { expect } = require('chai');

describe('NumberOperations', () => {

    describe('powNumber', () => {
        it('returns the power of given number', () => {
            expect(numberOperations.powNumber(2)).to.equal(4);
            expect(numberOperations.powNumber(3)).to.equal(9);
        });

        it('returns the power of given negative number', () => {
            expect(numberOperations.powNumber(-2)).to.equal(4);
            expect(numberOperations.powNumber(-3)).to.equal(9);
        });

        it('returns the power of zero', () => {
            expect(numberOperations.powNumber(0)).to.equal(0);
        });
    });

    describe('numberChecker', () => {
        it('validates a number if it is less than 100', () => {
            expect(numberOperations.numberChecker(1)).to.equal('The number is lower than 100!')
        });

        it('validates a number that it equal to 100', () => {
            expect(numberOperations.numberChecker(100)).to.equal('The number is greater or equal to 100!')
        });

        it('validates a number that it greater than 100', () => {
            expect(numberOperations.numberChecker(101)).to.equal('The number is greater or equal to 100!')
        });

        it('parses a number and validates if it is less than 100', () => {
            expect(numberOperations.numberChecker('1')).to.equal('The number is lower than 100!')
        });

        it('parses a number and validates if it is equal to 100', () => {
            expect(numberOperations.numberChecker('100')).to.equal('The number is greater or equal to 100!')
        });

        it('parses a number and validates if it is greater than 100', () => {
            expect(numberOperations.numberChecker('101')).to.equal('The number is greater or equal to 100!')
        });

        it('throws error when argument is NaN', () => {
            expect(function() { numberOperations.numberChecker('Peter') }).to.throw();
        });

        it('throws error when argument is object', () => {
            expect(function() { numberOperations.numberChecker({ a, d }) }).to.throw();
        });

        it('throws error when argument is array', () => {
            expect(function() { numberOperations.numberChecker(['a', 'd']) }).to.throw();
        });

    });

    describe('sumArrays', () => {
        it('loops through the arrays and sums numbers at same indexes', () => {
            expect(numberOperations.sumArrays([1, 1], [2, 2])).to.eql([3, 3]);
        });

        it('loops through the arrays with different length and sums numbers at same indexes', () => {
            expect(numberOperations.sumArrays([1, 1], [2, 2, 2])).to.eql([3, 3, 2]);
        });

        it('loops through arrays of strings and concatenates', () => {
            let arr1 = ['a', 'b'];
            let arr2 = ['c', 'd'];
            expect(numberOperations.sumArrays(arr1, arr2)).to.eql(['ac', 'bd']);
        });

        it('loops through empty arrays and returns empty array', () => {
            let arr1 = [];
            let arr2 = [];
            expect(numberOperations.sumArrays(arr1, arr2)).to.eql([]);
        });
    });


})