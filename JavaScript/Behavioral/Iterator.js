/* Iterator is a behavioral design pattern that lets you
 traverse elements of a collection without exposing its 
 underlying representation (list, stack, tree, etc.). */

// using a List as an example
class List {
    firstElement = undefined;
    constructor(el) {
        this.firstElement = el;
    }
    size() {
        let counter = 1;
        let next = this.firstElement.next;
        while(next) {
            counter ++;
            next = next.next;
        }

        return counter;
    }
}

class Element {
    number = 0;
    constructor(num) {
        this.number = num;
    }

    setNext(n) {
        this.next = n; 
    }
}

//instantiating the list and some elements to be counted
const el1 = new Element(1);
const el2 = new Element(1);
const el3 = new Element(1);
const el4 = new Element(1);
el1.next = el2;
el2.next = el3;
el3.next = el4;
const list = new List(el1);
console.log(list.size());