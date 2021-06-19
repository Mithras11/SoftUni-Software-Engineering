class Parking {

    constructor(capacity) {
        this.capacity = capacity;
        this.vehicles = [];
    }

    addCar(carModel, carNumber) {
        if (this.capacity == 0) {
            throw new Error("Not enough parking space.");

        } else {

            this.vehicles.push({ carModel, carNumber, payed: false });
            this.capacity--;

            return `The ${carModel}, with a registration number ${carNumber}, parked.`;
        }
    }

    removeCar(carNumber) {
        if (!this.vehicles.some(x => x.carNumber === carNumber)) {
            throw new Error("The car, you're looking for, is not found.");

        } else {

            let car = this.vehicles.find(x => x.carNumber === carNumber);

            if (car.payed === false) {
                throw new Error(`${carNumber} needs to pay before leaving the parking lot.`);

            } else {
                let indx = this.vehicles.indexOf(car);
                this.vehicles.splice(indx, 1);

                return `${carNumber} left the parking lot.`;
            }
        }

    }

    pay(carNumber) {
        if (!this.vehicles.some(x => x.carNumber === carNumber)) {
            throw new Error(`${carNumber} is not in the parking lot.`);

        } else {

            let car = this.vehicles.find(x => x.carNumber === carNumber);

            if (car.payed) {
                throw new Error(`${carNumber}'s driver has already payed his ticket.`);

            } else {

                car.payed = true;
                return `${carNumber}'s driver successfully payed for his stay.`;
            }
        }
    }

    getStatistics(carNumber) {
        if (carNumber === undefined) {

            let result = `The Parking Lot has ${this.capacity} empty spots left.\n`;

            let sortedVehicles = this.vehicles.sort((a, b) => a.carModel.localeCompare(b.carModel));

            let data = sortedVehicles.reduce((acc, val) => {
                let hasPayed = val.payed ? 'Has payed' : 'Not payed';
                acc += `${val.carModel} == ${val.carNumber} - ${hasPayed}\n`;

                return acc;

            }, '');

            result += data;

            return result.trimEnd();

        } else {

            let car = this.vehicles.find(x => x.carNumber === carNumber);
            let hasPayed = car.payed ? 'Has payed' : 'Not payed';

            return `${car.carModel} == ${car.carNumber} - ${hasPayed}`;

        }


    }

}

const  parking  =  new  Parking(12);

console.log(parking.addCar("Volvo t600",  "TX3691CA"));
console.log(parking.getStatistics());

console.log(parking.pay("TX3691CA"));
console.log(parking.removeCar("TX3691CA"));