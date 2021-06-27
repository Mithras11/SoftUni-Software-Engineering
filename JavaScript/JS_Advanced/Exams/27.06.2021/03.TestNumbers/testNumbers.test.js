const testNumbers = require('./testNumbers');
const { expect, assert } = require('chai');

describe('Tests', () => {
    it('tests sum function with integers', () => {
        expect(testNumbers.sumNumbers(1, 2)).to.equal((3).toFixed(2));
    });

    it('tests sum function with float nums', () => {
        expect(testNumbers.sumNumbers(1.1, 2.2)).to.equal((3.30).toFixed(2));
    });

    it('tests sum function with float nums', () => {
        expect(testNumbers.sumNumbers(1.10000, 2.200000)).to.equal((3.30).toFixed(2));
    });

    it('tests sum function with negative nums', () => {
        expect(testNumbers.sumNumbers(-1, 2.2)).to.equal((1.20).toFixed(2));
    });

    it('tests sum function with zero', () => {
        expect(testNumbers.sumNumbers(0, 2.2)).to.equal((2.20).toFixed(2));
    });




    it("test2", function() {
        let num = 10;
        num = num.toFixed(2);
        expect(testNumbers.sumNumbers(5, 5)).to.equal(num);

    });

    it("test2.1", function() {
        let num = -10;
        num = num.toFixed(2);
        expect(testNumbers.sumNumbers(-5, -5)).to.equal(num);

    });

    it('sum function returns undefined with invalid parameters', () => {
        expect(testNumbers.sumNumbers('x', 4)).to.equal(undefined);
        expect(testNumbers.sumNumbers(4, 'x')).to.equal(undefined);
        expect(testNumbers.sumNumbers('x', 'y')).to.equal(undefined);
        expect(testNumbers.sumNumbers('x', [])).to.equal(undefined);
        expect(testNumbers.sumNumbers({}, [])).to.equal(undefined);
        expect(testNumbers.sumNumbers([])).to.equal(undefined);
        expect(testNumbers.sumNumbers()).to.equal(undefined);
        expect(testNumbers.sumNumbers(undefined, 5)).to.equal(undefined);
        expect(testNumbers.sumNumbers(5, undefined)).to.equal(undefined);
        expect(testNumbers.sumNumbers(5, null)).to.equal(undefined);
    });


    it("test1", function() {
        expect(testNumbers.sumNumbers('as', 'asdq')).to.equal(undefined);
        expect(testNumbers.sumNumbers(5, 'asdq')).to.equal(undefined);
        expect(testNumbers.sumNumbers('as', 5)).to.equal(undefined);
        expect(testNumbers.sumNumbers('as', undefined)).to.equal(undefined);
        expect(testNumbers.sumNumbers(undefined, 5)).to.equal(undefined);
        expect(testNumbers.sumNumbers(null, 5)).to.equal(undefined);
        expect(testNumbers.sumNumbers(5, null)).to.equal(undefined);



    });





    it('throws error when argument is NaN', () => {
        expect(function() { testNumbers.numberChecker('Peter') }).to.throw();
    });

    it('throws error when argument is object', () => {
        expect(function() { testNumbers.numberChecker({}) }).to.throw();
    });

    it('throws error when argument is array', () => {
        expect(function() { testNumbers.numberChecker(['a']) }).to.throw();
    });

    it('throws error when argument is undefined', () => {
        expect(function() { testNumbers.numberChecker() }).to.throw();
    });


    it("test1", function() {

        assert.throw(() => testNumbers.numberChecker('as'), (Error, 'The input is not a number!'))
        assert.throw(() => testNumbers.numberChecker(undefined), (Error, 'The input is not a number!'))
        assert.throw(() => testNumbers.numberChecker(isNaN), (Error, 'The input is not a number!'))

    });

    it('checks if number is even', () => {
        assert.equal(testNumbers.numberChecker(2), 'The number is even!');
        assert.equal(testNumbers.numberChecker(22), 'The number is even!');
        assert.equal(testNumbers.numberChecker(2), 'The number is even!');
        assert.equal(testNumbers.numberChecker(-2), 'The number is even!');
        assert.equal(testNumbers.numberChecker(-22), 'The number is even!');
        //assert.equal(testNumbers.numberChecker(-2.2), 'The number is even!');
    });

    it('checks if number is odd', () => {
        assert.equal(testNumbers.numberChecker(3), 'The number is odd!');
        assert.equal(testNumbers.numberChecker(33), 'The number is odd!');
        assert.equal(testNumbers.numberChecker(3.3), 'The number is odd!');
        assert.equal(testNumbers.numberChecker(-3), 'The number is odd!');
        assert.equal(testNumbers.numberChecker(-33), 'The number is odd!');
        assert.equal(testNumbers.numberChecker(-3.3), 'The number is odd!');
    });



    it('tests averageSumArray', () => {
        assert(testNumbers.averageSumArray([1, 2, 3], 2));
        assert(testNumbers.averageSumArray([-1, -2, -3], -2));
        assert(testNumbers.averageSumArray([-2, 2, -6], 2));
        assert(testNumbers.averageSumArray([2], 2));
        assert(testNumbers.averageSumArray([-2], -2));

    });



    it("test2", function() {

        expect(testNumbers.numberChecker(6)).to.equal('The number is even!');
        expect(testNumbers.numberChecker(5)).to.equal('The number is odd!');
    });

    it("test1", function() {
        let ok = testNumbers.averageSumArray([2, 2, 0])

        expect(testNumbers.averageSumArray([2, 2, 2])).to.equal(2);
        expect(testNumbers.averageSumArray([2, 2, 0])).to.equal(ok);


    });

});