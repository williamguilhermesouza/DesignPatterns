namespace Behavioral;

/* Observer is a behavioral design pattern that lets
you define a subscription mechanism to notify multiple
objects about any events that happen to the object they’re observing. */

// creating the Observer class and the Observable
public class Observer
{
    public class ObserverClass
    {
        public void Update()
        {
            Console.WriteLine("There was an update!!!");
        }
    }

    public class Observable
    {
        public List<ObserverClass> Observers { get; set; } = new List<ObserverClass>();

        public void NotifyObservers()
        {
            if (Observers.Count is 0) return;
            foreach(var observer in Observers)
            {
                observer.Update();
            }
        }
    }
}