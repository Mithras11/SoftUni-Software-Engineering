function getPersons() {

    class Person {
        constructor(firstName, lastName, age, email) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.email = email;
        }

        toString() {
            return `${this.firstName} ${this.lastName} (age: ${this.age}, email: ${this.email})`;
        }
    }

    const Anna = new Person('Anna', 'Simpson', 22, 'anna@yahoo.com');
    const SoftUni = new Person('SoftUni');
    const Stephan = new Person('Stephan', 'Johnson', 25);
    const Gabriel = new Person('Gabriel', 'Peterson', 24, 'g.p@gmail.com');

    return [Anna, SoftUni, Stephan, Gabriel];

}