/* Visitor is a behavioral design pattern that lets you 
separate algorithms from the objects on which they operate. */

// implementing the visitor class that has algorithms 
// that process firstclass obj, and firstclass
class Visitor {
    static processFirstClass(obj) {
        console.log(obj.firstProperty);
    }
}

class FirstClass {
    firstProperty = 'Visitor class called!!!';
}

// instantiation of first object
let firstObj = new FirstClass();
Visitor.processFirstClass(firstObj);