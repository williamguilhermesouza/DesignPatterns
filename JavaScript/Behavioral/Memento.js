/* Memento is a behavioral design pattern that lets you
 save and restore the previous state of an object without 
 revealing the details of its implementation. */

// creating of the memento class and the classes that
// will have the state saved
class Memento {
    static save(obj) {
        this.obj = obj.state;
    } 

    static getState(obj) {
        return this.obj;
    }
}

class FirstClass {
    state = 'first';
}

//instantiation and saving state at memento
let firstObj = new FirstClass();
Memento.save(firstObj);
firstObj.state = 999;
firstObj.state = Memento.getState(firstObj);
console.log(firstObj.state);