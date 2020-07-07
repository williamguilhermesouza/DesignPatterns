/* Singleton is a creational design pattern that lets you ensure that a class has 
 * only one instance, while providing a global access point to this instance.
 */

// the singleton is instantiated only the first time, all other calls return
// the same object
function Singleton(instanceParam) {
    
    if (!Singleton.instance) {
        Singleton.instance = this;
        this.instanceParam = instanceParam;
        this.getter = instanceParam => console.log(this.instanceParam);

    } 

    return Singleton.instance;
}

// first instantiation
let first = Singleton('first');

// when called again the first instance is returned
// and even if we had passed this argument, it will
// be ignored, because the properties are defined 
// only at the instantiation moment, and can't be modified
// using the param again
let second = Singleton('second');

first.getter(); // should output first
second.getter(); // should output first

