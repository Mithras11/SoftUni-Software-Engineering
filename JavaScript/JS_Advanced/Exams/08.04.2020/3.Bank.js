class Bank {
    constructor(bankName) {
        this._bankName = bankName;
        this.allCustomers = [];

    }

    newCustomer(customer) {

        let { firstName, lastName, personalId } = customer;

        if (this.allCustomers.some(x => x.firstName === firstName &&
                x.lastName === lastName &&
                x.personalId === personalId)) { //проверка само по Id?

            throw new Error(`${firstName} ${lastName} is already our customer!`)
        }

        this.allCustomers.push(customer);

        return customer;
    }

    depositMoney(personalId, amount) {

        let currCustomer = this.allCustomers.find(x => x.personalId === personalId);

        if (!currCustomer) {
            throw new Error('We have no customer with this ID!');
        }

        if (!currCustomer.hasOwnProperty('totalMoney')) {
            currCustomer.totalMoney = 0;
        }

        currCustomer.totalMoney += Number(amount); //?

        if (!currCustomer.hasOwnProperty('transactions')) {
            currCustomer.transactions = [];

        }

        let currTransaction = { type: 'made deposit of', amount };
        currCustomer.transactions.push(currTransaction);


        return `${currCustomer.totalMoney}$`;

    }

    withdrawMoney(personalId, amount) {

        let currCustomer = this.allCustomers.find(x => x.personalId === personalId);

        if (!currCustomer) {
            throw new Error('We have no customer with this ID!');
        }

        if (currCustomer.totalMoney < amount ||
            !currCustomer.hasOwnProperty('totalMoney')) { //???
            throw new Error(`${currCustomer.firstName} ${currCustomer.lastName} does not have enough money to withdraw that amount!`);
        }

        currCustomer.totalMoney -= amount;

        if (!currCustomer.hasOwnProperty('transactions')) {
            currCustomer.transactions = [];

        }

        let currTransaction = { type: 'withdrew', amount };
        currCustomer.transactions.push(currTransaction);


        return `${currCustomer.totalMoney}$`

    }

    customerInfo(personalId) {

        let currCustomer = this.allCustomers.find(x => x.personalId === personalId);


        if (!currCustomer) {
            throw new Error('We have no customer with this ID!');
        }

        let result = '';

        result += `Bank name: ${this._bankName}\n` +
            `Customer name: ${currCustomer.firstName} ${currCustomer.lastName}\n` +
            `Customer ID: ${personalId}\n` +
            `Total Money: ${currCustomer.totalMoney}$\n` +
            `Transactions:\n`;


        for (let i = currCustomer.transactions.length - 1; i >= 0; i--) {
            let { type, amount } = currCustomer.transactions[i];

            result += `${i+1}. ${currCustomer.firstName} ${currCustomer.lastName} ${type} ${amount}$!\n`;

        }

        return result.trimEnd();
    }


}


let  bank  =  new  Bank('SoftUni  Bank');

console.log(bank.newCustomer({ firstName:   'Svetlin',  lastName:   'Nakov',  personalId:  6233267 }));
//console.log(bank.newCustomer({ firstName:   'Svetlin',  lastName:   'Nakov',  personalId:  6233267 }));
console.log(bank.newCustomer({ firstName:   'Mihaela',  lastName:   'Mileva',  personalId:  4151596 }));

bank.depositMoney(6233267,  250);
console.log(bank.depositMoney(6233267,  250));
bank.depositMoney(4151596, 555);

console.log(bank.withdrawMoney(6233267,  125));

console.log(bank.customerInfo(6233267));