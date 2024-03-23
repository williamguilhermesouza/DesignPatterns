namespace Structural;
/*
 * Facade is a structural design pattern that provides a simplified
 * interface to a library, a framework, or any other complex set of classes.
 */


//big and complex code that's behind the facade
public class Facade
{
    public class BigAndComplex
    {
        public void ComplexMethod()
        {
            Console.WriteLine("I'm really complex!");
        }
    }

    public static void FacadeMethod()
    {
        var complexObj = new BigAndComplex();
        complexObj.ComplexMethod();
    }
}