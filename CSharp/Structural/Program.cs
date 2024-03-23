namespace Structural
{
    class Structural()
    {
        static void Main(string[] args)
        {
            if (args.Length < 1) return;
            if (args[0] == "Adapter")
            {
                var firstObj = new Adapter.First();
                var secondObj = Adapter.AdapterClass.AdaptFirstToSecond(firstObj);
                Console.WriteLine(secondObj.SecondProperty);

            }

            if (args[0] == "Bridge")
            {
                var firstObj = new Bridge.FirstClass();
                Console.WriteLine(firstObj.SecondClass.FirstProperty);
            }

            if (args[0] == "Composite")
            {
                var composite = new Composite();
                Console.WriteLine(composite.SumOfAllProperties());
            }

            if (args[0] == "Decorator")
            {
                Decorator.Decorate(() => Decorator.ToDecorate());
            }

            if (args[0] == "Facade")
            {
                Facade.FacadeMethod();
            }

            if (args[0] == "Flyweight")
            {
                var firstObj = new Flyweight.FirstClass();
                var secondObj = new Flyweight.SecondClass();
                firstObj.UseResource();
                secondObj.UseResource();
            }

            if (args[0] == "Proxy")
            {
                var firstObj = (Proxy.BigAndMessy) Proxy.ProxyMethod(0);
                var secondObj = (Proxy.ProxyClass) Proxy.ProxyMethod(1);

                Console.WriteLine(firstObj.FirstProperty);
                Console.WriteLine(secondObj.FirstProperty);
            }
        }
    }
}
