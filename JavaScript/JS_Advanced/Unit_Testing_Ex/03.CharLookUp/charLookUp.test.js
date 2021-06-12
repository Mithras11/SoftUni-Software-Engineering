const lookupChar = require('./charLookUp');
const { expect } = require('chai');

describe('CharLookUp', () => {
    it('returns undefined with invalid string', () => {
        expect(lookupChar(1234, 1)).to.be.undefined;
    });

    it('returns undefined with floating-point index', () => {
        expect(lookupChar('abcd', 1.1)).to.be.undefined;
    });

    it('returns undefined with invalid index', () => {
        expect(lookupChar('abcd', '1')).to.be.undefined;
    });

    it('returns "Incorrect index" with negative index', () => {
        expect(lookupChar('abcd', -1)).to.equal('Incorrect index');
    });

    it('returns "Incorrect index" with  index outside range', () => {
        expect(lookupChar('abcd', 8)).to.equal('Incorrect index');
    });

    it('returns char at index', () => {
        expect(lookupChar('abcd', 0)).to.equal('a');
        expect(lookupChar('abcd', 1)).to.equal('b');
        expect(lookupChar('abcd', 2)).to.equal('c');
        expect(lookupChar('abcd', 3)).to.equal('d');
    });

})