const { expect } = require('chai');
const isOddOrEven = require('./isOddOrEven');

describe('isOddOrEven', () => {
    it('returns undefined with invalid input', () => {
        expect(isOddOrEven(1)).to.be.undefined;
    });

    it('returns even for string with even length', () => {
        expect(isOddOrEven('aa')).to.equal('even');
    });

    it('returns odd for string with odd length', () => {
        expect(isOddOrEven('aaa')).to.equal('odd');
    });

})