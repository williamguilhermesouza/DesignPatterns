/* State is a behavioral design pattern that lets an
 object alter its behavior when its internal state 
 changes. It appears as if the object changed its class. */

// creates the FirstClass that behaves differently depending
// on the state
class FirstClass {
    state = 0;
    stateMethod() {
        if (this.state == 0) {
            console.log('State is 0!');
        } else {
            console.log('State is not 0!!!');
        }
    }
}

// instantiation of the firstclass and state using
let firstObj = new FirstClass();
firstObj.stateMethod();
firstObj.state = 1;
firstObj.stateMethod();