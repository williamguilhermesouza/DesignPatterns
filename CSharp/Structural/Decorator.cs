namespace Structural;
/* Decorator is a structural design pattern that lets
 you attach new behaviors to objects by placing these
  objects inside special wrapper objects that contain the behaviors. */

// creating decorator function that will be a wrapper around another 
// function
public class Decorator
{
    public static void Decorate(Action func)
    {
        func();
        Console.WriteLine("Decorated");
    }

    public static void ToDecorate()
    {
        Console.WriteLine("Works!");
    }
}