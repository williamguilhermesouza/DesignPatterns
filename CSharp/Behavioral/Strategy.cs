namespace Behavioral;

/* Strategy is a behavioral design pattern that lets you define a
family of algorithms, put each of them into a separate class, and
make their objects interchangeable. */

//The strategy class with a bunch of different algoritms, it is responsible
// to getting the context and them returning the desired solution
public class Strategy
{
    public int Property { get; set; }

    public Strategy(int context)
    {
        if (context == 1) firstAlgorithm();
        else secondAlgorithm();
    }

    private void firstAlgorithm()
    {
        Property = 0;
    }

    private void secondAlgorithm()
    {
        Property = 1;
    }
}