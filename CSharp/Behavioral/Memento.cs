namespace Behavioral;

/* Memento is a behavioral design pattern that lets you
 save and restore the previous state of an object without
 revealing the details of its implementation. */

// creating of the memento class and the classes that
// will have the state saved
public class Memento
{
    private static string? memento;
    public static void Save(FirstClass obj)
    {
        memento = obj.State;
    }

    public static string? Get()
    {
        return memento;
    }

    public class FirstClass
    {
        public string? State { get; set; } = "first";
    }
}