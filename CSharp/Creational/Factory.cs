namespace Creational;
/* FACTORY PATTERN
 * Factory Method is a creational design pattern that provides an interface for creating objects
 * in a superclass, but allows subclasses to alter the type of objects that will be created.
 */
public class Factory
{
    public interface ClassInterface
    {
        public void TellType();
    }
    public class CreatedClass1 : ClassInterface
    {
        public void TellType()
        {
            Console.WriteLine("Type 1");
        }
    }
    public class CreatedClass2 : ClassInterface
    {
        public void TellType()
        {
            Console.WriteLine("Type 2");
        }
    }

    public static ClassInterface Create(int type)
    {
        return type switch
        {
            1 => new CreatedClass1(),
            2 => new CreatedClass2(),
            _ => new CreatedClass1()
        };
    }
            
}