class Stringer {

    constructor(innerString, innerLength) {
        this.innerString = innerString;
        this.innerLength = Number(innerLength);
        this.string = innerString;
    }

    increase(value) {

        this.innerLength += value;

        if (this.innerLength < 0) {
            this.innerLength = 0;
        }

    }

    decrease(value) {

        this.innerLength -= value;

        if (this.innerLength < 0) {
            this.innerLength = 0;
        }

    }


    toString() {

        if (this.innerString.length > this.innerLength) {
            this.string = this.innerString.substring(0, this.innerLength) + '...';

        } else if (this.innerLength === 0) {
            this.string = '...';
        } else {
            this.string = this.innerString;
        }

        return this.string;
    }


}

let test = new Stringer("Test", 5);
console.log(test.toString()); // Test

test.decrease(3);
console.log(test.toString()); // Te...

test.decrease(5);
console.log(test.toString()); // ...

test.increase(4);
console.log(test.toString());