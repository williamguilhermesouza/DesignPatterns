namespace Behavioral;

/* Iterator is a behavioral design pattern that lets you
 traverse elements of a collection without exposing its
 underlying representation (list, stack, tree, etc.). */

// using a List as an example
public class Iterator
{
    public class ListIterator
    {
        private Element FirstElement;

        public ListIterator(Element el)
        {
            FirstElement = el;
        }

        public int Size()
        {
            int counter = 0;
            Element? next = FirstElement;
            while (next != null)
            {
                counter++;
                next = next.Next;
            }

            return counter;
        }
    }

    public class Element
    {
        public Element? Next { get; set; }
        private int Number = 0;

        public Element(int number)
        {
            Number = number;
        }
    }
    
}