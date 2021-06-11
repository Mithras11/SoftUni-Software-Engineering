const { expect } = require('chai');
const createCalculator = require('./addSubtract');

describe('Add_Subtract', () => {

    let calculator = '';

    beforeEach(function() {
        calculator = createCalculator();
    });

    //---Check for methods in calculator

    it('returns module with function add', () => {
        expect(Object.keys(calculator).includes('add')).to.be.true;
    });

    it('returns module with function subtract', () => {
        expect(Object.keys(calculator).includes('subtract')).to.be.true;
    });

    it('returns module with function get', () => {
        expect(Object.keys(calculator).includes('get')).to.be.true;
    });


    it('returns value of internal sum when calling function get', () => {
        expect(calculator.get()).to.equal(0);
    });

    it('returns false when searching for function set', () => {
        expect(Object.keys(calculator).includes('set')).to.be.false;
    });

    //Check if methods work properly

    it('adds valid argument to internal sum when calling function add', () => {
        calculator.add(1);
        expect(calculator.get()).to.equal(1);
    });

    it('parses valid string argument and adds to internal sum when calling function add', () => {
        calculator.add('1');
        expect(calculator.get()).to.equal(1);
    });

    it('subtracts valid argument from internal sum when calling function subtract', () => {
        calculator.subtract(1);
        expect(calculator.get()).to.equal(-1);
    });

    it('parses valid string argument and subtracts from internal sum when calling function subtract', () => {
        calculator.subtract('1');
        expect(calculator.get()).to.equal(-1);
    });

    //Check methods with invalid arguments

    it('calling function add with invalid argument returns NaN', () => {
        calculator.add('Mimi');
        expect(calculator.get()).to.be.NaN;
    });

    it('calling function subtract with invalid argument returns NaN', () => {
        calculator.subtract('Mimi');
        expect(calculator.get()).to.be.NaN;
    });



})