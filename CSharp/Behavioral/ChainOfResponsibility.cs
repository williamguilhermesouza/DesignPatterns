namespace Behavioral;

/* Chain of Responsibility is a behavioral design pattern that
 lets you pass requests along a chain of handlers. Upon receiving
  a request, each handler decides either to process the request or
  to pass it to the next handler in the chain. */

// a chain of classes that handle the request or pass it 
public class ChainOfResponsibility
{
    public class FirstOfChainOfResponsibility
    {
        public int FirstProperty;
        public FirstOfChainOfResponsibility(int obj)
        {
            if (obj == 0) passToSecond(obj);
        }

        private object passToSecond(int obj)
        {
            return new SecondOfChain(obj);
        }
    }

    public class SecondOfChain
    {
        public int FirstProperty;
        public SecondOfChain(int obj)
        {
            this.FirstProperty = obj;
        }
    }
}