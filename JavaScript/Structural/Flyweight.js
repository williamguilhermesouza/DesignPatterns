/* Flyweight is a structural design pattern that lets you
 fit more objects into the available amount of RAM by sharing 
 common parts of state between multiple objects instead of
  keeping all of the data in each object. */

// Flyweight with big resource shared between objects
class Flyweight {
    static BigAndRAMExpensiveResource = 0;
}

// first class that will use the resource
class FirstClass {
    useResource() {
        console.log(Flyweight.BigAndRAMExpensiveResource);
    }
}

// second class that will use the resource
class SecondClass {
    useResource() {
        console.log(Flyweight.BigAndRAMExpensiveResource);
    }
}

// instantiation of the classes and use of the resources

let firstObj = new FirstClass();
let secondObj = new SecondClass();
firstObj.useResource();
secondObj.useResource();