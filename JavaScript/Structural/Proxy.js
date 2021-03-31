/* Proxy is a structural design pattern that lets you
 provide a substitute or placeholder for another object.
  A proxy controls access to the original object, allowing
   you to perform something either before or after the 
   request gets through to the original object. */

// create a messy big class that needs access control
// that will be handled by the proxy
class BigAndMessy {
    firstProperty = 0;
}

// controls the access to big and messy
class Proxy {
    firstProperty = 1;

    constructor(arg) {
        if (arg == 0) {
            return new BigAndMessy();
        } else {
            return this;
        }
    }
}

// instantiate an object that access bigAndMessy and 
// another object that don' access
let firstObj = new Proxy(0);
let secondObj = new Proxy(1);

console.log(firstObj.firstProperty);
console.log(secondObj.firstProperty);