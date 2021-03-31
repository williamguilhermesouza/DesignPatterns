/* Bridge is a structural design pattern that lets you
 split a large class or a set of closely related classes 
 into two separate hierarchies—abstraction and 
 implementation—which can be developed independently of each other. */

// creation of the first class which will have
//an bridge object that will treat the second
//class properties
class FirstClass {
    SecondClass = new Bridge();
}

class SecondClass {
    firstProperty = 0;
}

class Bridge {
    constructor() {
        return new SecondClass();
    }
}

// instantiation of first class and access to second
firstObj = new FirstClass();
console.log(firstObj.SecondClass.firstProperty);
