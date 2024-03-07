namespace Behavioral;

public class Command
{
    public static void CommandMethod(string data)
    {
        Console.WriteLine(data);
    }
    public class Button
    {
        public void Save(string data)
        {
            CommandMethod(data);
        }
    }
    public class MenuItem
    {
        public void Save(string data)
        {
            CommandMethod(data);
        }
    }
    public class Shortcut
    {
        public void Save(string data)
        {
            CommandMethod(data);
        }
    }
}