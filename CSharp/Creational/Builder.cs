namespace Creational;
/* Builder is a creational design pattern that lets you
construct complex objects step by step. The pattern allows
you to produce different types and representations of an object
using the same construction code. */

// Builder class with it's building methods
public class Builder
{
    public int? FirstParam;
    public void BuildMethod1()
    {
        FirstParam = 0;
    }

    public void BuildMethod2()
    {
        FirstParam = 1;
    }
}