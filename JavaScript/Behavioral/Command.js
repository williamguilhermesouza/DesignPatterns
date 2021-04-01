/* Command is a behavioral design pattern that turns a 
request into a stand-alone object that contains all 
information about the request. This transformation lets 
you pass requests as a method arguments, delay or queue 
a request’s execution, and support undoable operations. */

// the creation of the command function which can be called
// from diferent interfaces
function Command(data) {
    console.log(data);
}

class Button {
    save(data) {
        Command(data);
    }
}

class MenuItem {
    save(data) {
        Command(data);
    }
}

class Shortcut {
    save(data) {
        Command(data);
    }
}

let button = new Button();
let menuItem = new MenuItem();
let shortcut = new Shortcut();

button.save('Button');
menuItem.save('MenuItem');
shortcut.save('Shortcut');