/*
 * Facade is a structural design pattern that provides a simplified 
 * interface to a library, a framework, or any other complex set of classes.
 */


//big and complex code that's behind the facade
class BigAndComplex {
    complexMethod() {
        console.log("I'm really complex");
    }
}

// facade pattern
function Facade() {
    // simple call to complex func
    let complexObj = new BigAndComplex();
    complexObj.complexMethod();
}

// facade function to call complex things in simple way
Facade();
