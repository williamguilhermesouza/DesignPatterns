namespace Structural;
/* Flyweight is a structural design pattern that lets you
 fit more objects into the available amount of RAM by sharing
 common parts of state between multiple objects instead of
  keeping all of the data in each object. */

// Flyweight with big resource shared between objects
public class Flyweight
{
    public static int BigAndRAMExpensiveResource = 0;

    public class FirstClass
    {
        public void UseResource()
        {
            Console.WriteLine(BigAndRAMExpensiveResource);
        }
    }
    public class SecondClass
    {
        public void UseResource()
        {
            Console.WriteLine(BigAndRAMExpensiveResource);
        }
    }

}