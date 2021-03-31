/* Composite is a structural design pattern that lets
 you compose objects into tree structures and then work 
 with these structures as if they were individual objects. */

// creation of the composite class that goes as a tree
// to get the info from its properties
class Composite {
    
    sumOfAllProperties() {
        return this.firstProperty + this.secondProperty + this.thirdProperty.sumOfAllProperties();
    }

    firstProperty = 1;
    secondProperty = 2;
    thirdProperty = new FirstSubClass();
}

class FirstSubClass {
    sumOfAllProperties() {
        return this.firstProperty + this.secondProperty + this.thirdProperty.sumOfAllProperties();
    }

    firstProperty = 1;
    secondProperty = 2;
    thirdProperty = new SecondSubClass();
}

class SecondSubClass {
    sumOfAllProperties() {
        return this.firstProperty + this.secondProperty + this.thirdProperty;
    }

    firstProperty = 1;
    secondProperty = 2;
    thirdProperty = 3;
}

// instantiation of composite class and getting
// the sum from all properties
let compositeObj = new Composite();
console.log(compositeObj.sumOfAllProperties());