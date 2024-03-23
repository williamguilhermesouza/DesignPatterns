namespace Structural;
/* Composite is a structural design pattern that lets
 you compose objects into tree structures and then work
 with these structures as if they were individual objects. */

// creation of the composite class that goes as a tree
// to get the info from its properties
public class Composite
{
    public int FirstProperty = 1;
    public int SecondProperty = 2;
    public FirstSubClass ThirdProperty = new FirstSubClass();

    public int SumOfAllProperties()
    {
        return FirstProperty + SecondProperty + ThirdProperty.sumOfAllProperties();
    }

    public class FirstSubClass
    {
        public int sumOfAllProperties() {
            return firstProperty + secondProperty + thirdProperty.sumOfAllProperties();
        }

        private int firstProperty = 1;
        private int secondProperty = 2;
        private SecondSubClass thirdProperty = new SecondSubClass();
    }
    
    public class SecondSubClass {
        public int sumOfAllProperties() {
            return firstProperty + secondProperty + thirdProperty;
        }

        private int firstProperty = 1;
        private int secondProperty = 2;
        private int thirdProperty = 3;
    }
}