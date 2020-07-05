/* FACTORY PATTERN
 * Factory Method is a creational design pattern that provides an interface for creating objects 
 * in a superclass, but allows subclasses to alter the type of objects that will be created.
 */


// this is the superclass 
class ObjectInterface {
    constructor() {}
    tellType() {}
}

// first class that inherits from super and is directly created by the factory
class CreatedObject1 extends ObjectInterface {
    tellType() {
        console.log('This is an obj 1');
    }
}

// second class that inherits from super and is directly created by the factory
class CreatedObject2 extends ObjectInterface {
    tellType() {
        console.log('This is an obj 2');
    }
}

// this is the factory create function, that creates the objects
function create(type) {
    switch (type) {
        case 1:
            return new CreatedObject1;
            break;
        case 2:
            return new CreatedObject2;
            break;
    }
}

// creation test and method call
var object1 = create(1);
var object2 = create(2);

object1.tellType();
object2.tellType();
