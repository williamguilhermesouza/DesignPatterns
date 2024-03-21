namespace Creational;
/* Singleton is a creational design pattern that lets you ensure that a class has
 * only one instance, while providing a global access point to this instance.
 */

// the singleton is instantiated only the first time, all other calls return
// the same object
public sealed class Singleton
{
    private static Singleton? instance;
    public static string? Param = default!;

    public static Singleton GetInstance(string param)
    {
        if (instance == null)
        {
            var singleton = new Singleton();
            Param = param;
            instance = singleton;
            return instance;
        }
        return instance;
    }

    public void OutputParam()
    {
        Console.WriteLine(Param);
    }
}