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

            if (args[0] == "Builder")
            {
                var obj1 = new Builder();
                var obj2 = new Builder();
                obj1.BuildMethod1();
                obj2.BuildMethod2();
                Console.WriteLine(obj1.FirstParam);
                Console.WriteLine(obj2.FirstParam);
            }

            if (args[0] == "Factory")
            {
                var obj1 = Factory.Create(1);
                var obj2 = Factory.Create(2);
                obj1.TellType();
                obj2.TellType();
            }

            if (args[0] == "Prototype")
            {
                var firstObj = new Prototype();
                firstObj.SecondProperty = 2;
                var secondObj = firstObj.Clone();
                Console.WriteLine(secondObj.SecondProperty);
            }

            if (args[0] == "Singleton")
            {
                var first = Singleton.GetInstance("first");
                var second = Singleton.GetInstance("second");
                first.OutputParam();
                second.OutputParam();
            }
        }
    }
}