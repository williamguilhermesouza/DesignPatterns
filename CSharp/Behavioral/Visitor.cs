namespace Behavioral;

/* Visitor is a behavioral design pattern that lets you
separate algorithms from the objects on which they operate. */

// implementing the visitor class that has algorithms 
// that process firstclass obj, and firstclass
public class Visitor
{
    public static void ProcessFirstClass(FirstClass obj) 
    {
        Console.WriteLine(obj.FirstProperty);
    }

    public class FirstClass
    {
        public string FirstProperty = "First Class has been called!";
    }
}