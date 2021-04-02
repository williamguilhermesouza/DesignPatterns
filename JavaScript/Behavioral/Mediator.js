/* Mediator is a behavioral design pattern that lets you
 reduce chaotic dependencies between objects. The pattern 
 restricts direct communications between the objects and 
 forces them to collaborate only via a mediator object. */

// creation of two classes and their mediator
class Mediator {
    static communicateFirstSecond(first, second) {
        second.firstProperty = first.firstProperty
    }
}

class FirstClass {
    firstProperty = 0;
}

class SecondClass {
    firstProperty = undefined;
}

// instantiation of the objects
let firstObj = new FirstClass();
let secondObj = new SecondClass();
Mediator.communicateFirstSecond(firstObj, secondObj);
console.log(secondObj.firstProperty);