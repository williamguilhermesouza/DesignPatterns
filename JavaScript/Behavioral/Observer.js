/* Observer is a behavioral design pattern that lets 
you define a subscription mechanism to notify multiple 
objects about any events that happen to the object they’re observing. */

// creating the Observer class and the Observable
class Observer {
    update() {
        console.log('There was an update!!!');
    }
}

class Observable {
    observers = [];

    notifyObservers() {
        if (this.observers.length != 0) {
            for(let i = 0; i < this.observers.length ; i++) {
                this.observers[i].update();
            }
        }
    }
}

// instantiating some observers and updating
let observable = new Observable();
observable.observers.push(new Observer(), new Observer(), new Observer());
observable.notifyObservers();