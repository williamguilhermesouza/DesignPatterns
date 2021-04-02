/* Template Method is a behavioral design pattern 
that defines the skeleton of an algorithm in the
 superclass but lets subclasses override specific 
 steps of the algorithm without changing its structure. */

// creation of the template class and the subclass that
// overrides only one method
class Template {
    firstMethod() {}
    secondMethod() {}
}

class FirstClass extends Template {
    firstMethod() {
        console.log("Overrid of first method of template!");
    }
}

// instantiation of first class
let firstObj = new FirstClass();
firstObj.firstMethod();