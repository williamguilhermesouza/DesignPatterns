namespace Structural;
/* Bridge is a structural design pattern that lets you
 split a large class or a set of closely related classes
 into two separate hierarchies—abstraction and
 implementation—which can be developed independently of each other. */

// creation of the first class which will have
//an bridge object that will treat the second
//class properties
public class Bridge
{
    public class FirstClass
    {
        public SecondClass SecondClass = BridgeMethod();
    }

    public class SecondClass
    {
        public int FirstProperty = 0;
    }

    public static SecondClass BridgeMethod()
    {
        return new SecondClass();
    }
}