namespace Creational;
/* Abstract Factory is a creational design pattern that
lets you produce families of related objects without
specifying their concrete classes. */

//Interfaces of the objects to be created
public abstract class AbstractFactory
{
    public class AbstractClass1
    {
        public int Property0 = 0;
    }

    public class AbstractClass2
    {
        public int Property1 = 1;
    }

    public static AbstractClass1 CreateAbstractClass1()
    {
        return new AbstractClass1();
    }

    public static AbstractClass2 CreateAbstractClass2()
    {
        return new AbstractClass2();
    }
}