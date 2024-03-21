namespace Creational;
/* Prototype is a creational design pattern that lets you copy
existing objects without making your code dependent on their classes. */

// Prototype class has the clone method that clones itself into another object
public class Prototype
{
    public int FirstProperty { get; set; } = 0;
    public int SecondProperty { get; set; } = 1;

    public Prototype Clone()
    {
        var cloneObj = new Prototype();
        cloneObj.FirstProperty = FirstProperty;
        cloneObj.SecondProperty = SecondProperty;
        return cloneObj;
    }
}