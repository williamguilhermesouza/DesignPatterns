/* Chain of Responsibility is a behavioral design pattern that
 lets you pass requests along a chain of handlers. Upon receiving
  a request, each handler decides either to process the request or 
  to pass it to the next handler in the chain. */

// a chain of classes that handle the request or pass it 
class FirstOfChainOfResponsibility {
    process() {}
    passToSecond(data) {
        return new SecondOfChain(data);
    }
    constructor(obj) {
        if (obj == 0) {
            return this.passToSecond(obj);
        }
    }
}

class SecondOfChain {

    constructor(obj) {
        this.firstProperty = obj;
    }
}

//calling the chain that passes the data through
let obj = new FirstOfChainOfResponsibility(0);
console.log(obj.firstProperty);