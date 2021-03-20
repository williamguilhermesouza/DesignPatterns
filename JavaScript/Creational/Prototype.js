/* Prototype is a creational design pattern that lets you copy 
existing objects without making your code dependent on their classes. */

// Prototype class has the clone method that clones itself into another object
class Prototype {
    firstProperty;
    secondProperty;

    //constructor that's called in the instantiation
    constructor() {this.firstProperty = 0; this.secondProperty = 1;}

    // clone function responsible for cloning the object with all the properties
    clone() {
        let cloneObj = new Prototype();
        cloneObj.firstProperty = this.firstProperty;
        cloneObj.secondProperty = this.secondProperty;
        return cloneObj;
    }
}

// creating the prototype
FirstObj = new Prototype();
FirstObj.secondProperty = 2;

// cloning it, and outputting secondProperty
SecondObj = FirstObj.clone();
console.log(SecondObj.secondProperty);