namespace Structural;
/* Adapter is a structural design pattern that allows
objects with incompatible interfaces to collaborate. */

// Creating two incompatible classes
public class Adapter
{
    public class First
    {
        public int FirstProperty = 0;
        public int SecondProperty = 1;
    }

    public class Second
    {
        public string FirstProperty = "0";
        public string SecondProperty = "1";
    }

    public static class AdapterClass
    {
        public static Second AdaptFirstToSecond(First first)
        {
            var second = new Second();
            second.FirstProperty = first.FirstProperty.ToString();
            second.SecondProperty = first.SecondProperty.ToString();
            return second;
        }
    }
}