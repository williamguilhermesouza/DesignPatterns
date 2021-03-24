/* Adapter is a structural design pattern that allows 
objects with incompatible interfaces to collaborate. */

// Creating two incompatible classes
class FirstClass {
    firstProperty = 0;
    secondProperty = 1;
}

class SecondClass {
    firstProperty = '';
    secondProperty = '';
}

// creating the adapter to pass first class to second
class Adapter {
    constructor() {
        if (this.constructor === AbstractFactory) {
            throw new TypeError("Can't instantiate abstract class!!!");
        }
    }

    static adaptFirstToSecond(firstObj) {
        let secondObj = new SecondClass();
        secondObj.firstProperty = `${firstObj.firstProperty}`;
        secondObj.secondProperty = `${firstObj.secondProperty}`;
        return secondObj;
    }
}

// creating an object and adapting it
let firstObj = new FirstClass();
let secondObj = Adapter.adaptFirstToSecond(firstObj);
console.log(secondObj.secondProperty);