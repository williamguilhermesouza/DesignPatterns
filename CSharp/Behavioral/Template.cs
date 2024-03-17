namespace Behavioral;

/* Template Method is a behavioral design pattern
that defines the skeleton of an algorithm in the
 superclass but lets subclasses override specific
 steps of the algorithm without changing its structure. */

// creation of the template class and the subclass that
// overrides only one method
public class Template
{
    public class TemplateClass
    {
        public void FirstMethod(){}
        public void SecondMethod(){}
    }

    public class FirstClass : TemplateClass
    {
        public new void FirstMethod()
        {
            Console.WriteLine("Template class has been overriden!");
        }
    }
}