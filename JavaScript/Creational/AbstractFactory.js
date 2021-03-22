/* Abstract Factory is a creational design pattern that 
lets you produce families of related objects without 
specifying their concrete classes. */

//Interfaces of the objects to be created
class Interface1 {
    property0 = 0;
}

class Interface2 {
    property1 = 1;
}

// The abstract factory that origins all other classes,
// should have creation methods of the interfaces above.
// These are static methods as the class is abstract
class AbstractFactory {
    constructor() {
        if (this.constructor === AbstractFactory) {
            throw new TypeError("Can't instantiate abstract class!!!");
        }
    }
    static createInterface1() {
        let obj = new Interface1();
        return obj;
    }

    static createInterface2() {
        let obj = new Interface2();
        return obj;
    }
}

// using the abstract class to create the objects
let obj1 = AbstractFactory.createInterface1();
let obj2 = AbstractFactory.createInterface2();

console.log(obj1.property0);
console.log(obj2.property1);