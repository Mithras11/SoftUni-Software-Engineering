class Vacationer {
    constructor(fullName, creditCard) {

        this.fullName = fullName;
        this.creditCard = creditCard;
        this.idNumber = this.generateIDNumber();
        this.wishList = [];
    }

    get fullName() {
        return this._fullName;
    }

    set fullName(names) {

        if (names.length !== 3) {
            throw new Error("Name must include first name, middle name and last name");
        }


        let regexp = /^([A-Z][a-z]+)$/;
        let isValid = false;

        for (const name of names) {
            isValid = regexp.test(name);
        }

        if (!isValid) {
            throw new Error('Invalid full name');
        }

        let [firstName, middleName, lastName] = names;
        this._fullName = { firstName, middleName, lastName };

        //console.log(this._fullName);
    }

    get creditCard() {
        return this._creditCard;
    }

    set creditCard(value) {
        if (value === undefined) {
            this._creditCard = { cardNumber: 1111, expirationDate: '', securityNumber: 111 };

        } else {

            if (value.length !== 3) {

                throw new Error("Missing credit card information");
            }

            let [cardNumber, expirationDate, securityNumber] = value;

            if (typeof cardNumber !== 'number' || typeof securityNumber !== 'number') {
                throw new Error("Invalid credit card details");
            }

            this._creditCard = { cardNumber, expirationDate, securityNumber };
        }
    }

    // get idNumber() {
    //     return this._idNumber;
    // }
    // set idNumber(value) {
    //     this._idNumber = this.generateIDNumber();
    // }

    generateIDNumber() {
        let { firstName, middleName, lastName } = this.fullName;

        let firstNum = firstName.charCodeAt(0);
        let secondNum = middleName.length;

        let x = lastName.slice(-1);
        let isVowel = x == "a" || x == "e" || x == "i" || x == "o" || x == "u";

        let thirdNum = '7';
        if (isVowel) {
            thirdNum = '8';
        }


        return 231 * firstNum + 139 * secondNum + thirdNum;

    }

    addCreditCardInfo(input) {
        if (input.length !== 3) {

            throw new Error("Missing credit card information");
        }

        let [cardNumber, expirationDate, securityNumber] = input;

        if (typeof cardNumber !== 'number' || typeof securityNumber !== 'number') {
            throw new Error("Invalid credit card details");
        }

        this.creditCard.cardNumber = cardNumber;
        this.creditCard.expirationDate = expirationDate;
        this.creditCard.securityNumber = securityNumber;
    }

    addDestinationToWishList(destination) {
        //провери дължината на дестинацията

        if (this.wishList.some(x => x === destination)) {
            throw new Error("Destination already exists in wishlist");
        }

        this.wishList.push(destination);

        this.wishList.sort((a, b) => a.length - b.length);
    }

    getVacationerInfo() {
        let wishListMsg = '';

        if (this.wishList.length == 0) {
            wishListMsg = 'empty';
        } else {
            wishListMsg = this.wishList.join(', ');
        }



        let { firstName, middleName, lastName } = this.fullName;
        let { cardNumber, expirationDate, securityNumber } = this.creditCard;

        let result = `Name: ${firstName} ${middleName} ${lastName}\n` +
            `ID Number: ${this.idNumber}\n` +
            `Wishlist:\n` +
            `${wishListMsg}\n` +
            `Credit Card:\n` +
            `Card Number: ${cardNumber}\n` +
            `Expiration Date: ${expirationDate}\n` +
            `Security Number: ${securityNumber}\n`;

        return result;
    }


}

//let classInstance1 = new Vacationer(["Vania", "Ivanova", "Zhivk0va"]);
//let classInstance4 = new Vacationer(["Tania", "Ivanova", "Zhivkova"], ['123456789', "10/01/2018", 777])

let vacationer1 = new Vacationer(["Vania", "Ivanova", "Zhivkova"]);
//let vacationer2 = new Vacationer(["Tania", "Ivanova", "Zhivkova"], [123456789, "10/01/2018", 777]);

vacationer1.addDestinationToWishList('Spain');
vacationer1.addDestinationToWishList('Germany');
vacationer1.addDestinationToWishList('Bali');

// Return information about the vacationers
console.log(vacationer1.getVacationerInfo());
console.log(vacationer2.getVacationerInfo());