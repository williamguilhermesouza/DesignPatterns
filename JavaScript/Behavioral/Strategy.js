/* Strategy is a behavioral design pattern that lets you define a 
family of algorithms, put each of them into a separate class, and 
make their objects interchangeable. */

//The strategy class with a bunch of different algoritms, it is responsible
// to getting the context and them returning the desired solution
class Strategy {
    constructor(context) {
        if (context == 1) {
            this.firstAlgorithm();
        } else {
            this.secondAlgorithm();
        }
    }
    property1;


    firstAlgorithm() {
        this.property1 = 0;
    }

    secondAlgorithm() {
        this.property1 = 1;
    }
}

// the code that calls the strategy pattern don't have to know about the 
// strategies
let context = 1;
let obj = new Strategy(context);
console.log(obj.property1);