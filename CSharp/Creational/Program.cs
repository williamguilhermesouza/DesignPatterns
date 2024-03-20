namespace Creational
{
    class Creational()
    {
        static void Main(string[] args)
        {
            if (args.Length < 1) return;
            if (args[0] == "AbstractFactory")
            {
                var obj1 = AbstractFactory.CreateAbstractClass1();
                var obj2 = AbstractFactory.CreateAbstractClass2();

                Console.WriteLine(obj1.Property0);
                Console.WriteLine(obj2.Property1);
            }
            if (args[0] == "Builder") {}
            if (args[0] == "Factory") {}
            if (args[0] == "Prototype") {}
            if (args[0] == "Singleton") {}
        }
    }
}