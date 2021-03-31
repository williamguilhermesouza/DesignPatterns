/* Decorator is a structural design pattern that lets
 you attach new behaviors to objects by placing these
  objects inside special wrapper objects that contain the behaviors. */

// creating decorator function that will be a wrapper around another 
// function
function Decorator(func) {
    func();
    console.log('decorated');
}

// the function to be decorated
function Decorated() {
    console.log('works!!!');
}

//calling the decorated function
Decorator(Decorated);
