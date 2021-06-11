const { expect } = require('chai');
const rgbToHexColor = require('./rgb-to-hex');

describe('RGB_to_HEX', () => {

    it('returns colors in Hex with valid input', () => {
        expect(rgbToHexColor(255, 158, 170)).to.equal('#FF9EAA');
    });


    it('returns white in Hex with valid input', () => {
        expect(rgbToHexColor(0, 0, 0)).to.equal('#000000');
    });

    it('returns undefined when red is NaN', () => {
        expect(rgbToHexColor('a', 1, 1)).to.equal(undefined);
    });

    it('returns undefined when green is NaN', () => {
        expect(rgbToHexColor(1, 'x', 1)).to.equal(undefined);
    });

    it('returns undefined when blue is NaN', () => {
        expect(rgbToHexColor(1, 1, 'z')).to.equal(undefined);
    });

    it('returns undefined when red is less than zero', () => {
        expect(rgbToHexColor(-1, 1, 1)).to.equal(undefined);
    });

    it('returns undefined when green is less than zero', () => {
        expect(rgbToHexColor(1, -1, 1)).to.equal(undefined);
    });

    it('returns undefined when blue is less than zero', () => {
        expect(rgbToHexColor(1, 1, -1)).to.equal(undefined);
    });

    it('returns undefined when red is bigger than 255', () => {
        expect(rgbToHexColor(256, 1, 1)).to.equal(undefined);
    });

    it('returns undefined when green is bigger than 255', () => {
        expect(rgbToHexColor(1, 256, 1)).to.equal(undefined);
    });

    it('returns undefined when blue is bigger than 255', () => {
        expect(rgbToHexColor(1, 1, 256)).to.equal(undefined);
    });


});