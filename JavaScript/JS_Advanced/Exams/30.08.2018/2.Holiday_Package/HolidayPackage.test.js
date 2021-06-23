const HolidayPackage = require('./HolidayPackage');
const { assert, expect } = require('chai');

describe('class HolidayPackage', () => {
    let package;
    let destination = 'South';
    let season = "Autumn";
    beforeEach(() => package = new HolidayPackage(destination, season));

    it('tests valid instantiation', () => {
        assert.equal(package.destination, destination);
        assert.equal(package.season, season);
        expect(package.vacationers).to.eql([]);
        assert.equal(package.insuranceIncluded, false);
    });

    it('returns message with no vacationers', () => {
        expect(package.showVacationers()).to.equal('No vacationers are added yet');
    });

    it('returns  vacationers', () => {
        let vacationer = 'Kaloyan Ivanov';
        package.addVacationer(vacationer);
        assert.equal(package.showVacationers(), 'Vacationers:\nKaloyan Ivanov');
    });

    it('showVacationers should return message', () => {
        holidayPackage.addVacationer('Losho Toshi');
        holidayPackage.addVacationer('Tosho Loshi');
        assert.equal(holidayPackage.showVacationers(), `Vacationers:\n${holidayPackage.vacationers.join("\n")}`);
    });

    it('tests addVacationer with empty string', () => {
        expect(function() { package.addVacationer(' ') }).to.throw(Error, 'Vacationer name must be a non-empty string');
    });

    it('tests addVacationer with invalid type of name', () => {
        expect(function() { package.addVacationer(15) }).to.throw(Error, 'Vacationer name must be a non-empty string');
    });

    it('tests addVacationer with invalid name length', () => {
        expect(function() { package.addVacationer('Kalo Alo Balo') }).to.throw(Error, 'Name must consist of first name and last name');
    });

    it('tests addVacationer with invalid name length', () => {
        expect(function() { package.addVacationer('Kalo') }).to.throw(Error, 'Name must consist of first name and last name');
    });

    it('add valid vacationer', () => {
        package.addVacationer('Kaloyan Ivanov');
        assert.equal(package.vacationers.length, 1);
    });

    it('addVacationer should add correct name', () => {
        holidayPackage.addVacationer('Kaloyan Ivanov');
        //assert.equal(holidayPackage.vacationers.length, 1); 
        assert.equal(holidayPackage.vacationers.includes('Kaloyan Ivanov'), true);
    });


    it('tests insuranceIncluded with invalid parameters', () => {
        expect(function() { package.insuranceIncluded = 123 }).to.throw(Error, 'Insurance status must be a boolean');
    });

    it('tests insuranceIncluded with valid parameters', () => {
        package.insuranceIncluded = true;
        expect(package.insuranceIncluded).to.equal(true);
    });

    it('tests generateHolidayPackage with no vacationers', () => {
        expect(function() { package.generateHolidayPackage() }).to.throw(Error, 'There must be at least 1 vacationer added');
    });

    it('tests generateHolidayPackage with season different than Summer/Winter', () => {
        package.addVacationer('Kaloyan Ivanov');
        expect(package.generateHolidayPackage()).to.equal("Holiday Package Generated\n" +
            "Destination: " + package.destination + "\n" +
            package.showVacationers() + "\n" +
            "Price: " + 400);
    });

    it('tests generateHolidayPackage with season Summer', () => {
        package.addVacationer('Kaloyan Ivanov');
        package.season = 'Summer';
        expect(package.generateHolidayPackage()).to.equal("Holiday Package Generated\n" +
            "Destination: " + package.destination + "\n" +
            package.showVacationers() + "\n" +
            "Price: " + 600);
    });

    it('tests generateHolidayPackage with season Winter', () => {
        package.addVacationer('Kaloyan Ivanov');
        package.season = 'Winter';
        expect(package.generateHolidayPackage()).to.equal("Holiday Package Generated\n" +
            "Destination: " + package.destination + "\n" +
            package.showVacationers() + "\n" +
            "Price: " + 600);
    });

    it('tests generateHolidayPackage with insurance included', () => {
        package.addVacationer('Kaloyan Ivanov');
        package.season = 'Winter';
        package.insuranceIncluded = true;
        expect(package.generateHolidayPackage()).to.equal("Holiday Package Generated\n" +
            "Destination: " + package.destination + "\n" +
            package.showVacationers() + "\n" +
            "Price: " + 700);
    });


});