/* Builder is a creational design pattern that lets you 
construct complex objects step by step. The pattern allows 
you to produce different types and representations of an object 
using the same construction code. */

// Builder class with it's building methods
class Builder {
    // first method gives the object firstParam
    buildMethod1() {
        this.firstParam = 0;
    }

    // second method gives the object secondParam
    buildMethod2() {
        this.secondParam = 1;
    }

}

firstObj = new Builder();
secondObj = new Builder();

firstObj.buildMethod1();
secondObj.buildMethod2();

console.log(firstObj.firstParam);
console.log(secondObj.secondParam);