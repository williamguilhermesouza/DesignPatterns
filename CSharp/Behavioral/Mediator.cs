namespace Behavioral;

/* Mediator is a behavioral design pattern that lets you
 reduce chaotic dependencies between objects. The pattern
 restricts direct communications between the objects and
 forces them to collaborate only via a mediator object. */

// creation of two classes and their mediator
public class Mediator
{ 
     public static void CommunicateFirstToSecond(FirstClass first, SecondClass second)
     {
         second.FirstProperty = first.FirstProperty;
     }

     public class FirstClass
     {
         public int FirstProperty = 0;
     }

     public class SecondClass
     {
         public int? FirstProperty;
     }
}