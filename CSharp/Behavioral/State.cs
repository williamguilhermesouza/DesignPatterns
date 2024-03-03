using System;

namespace Behavioral
{
//  <summary>State is a behavioral design pattern that lets an
//  object alter its behavior when its internal state 
//  changes. It appears as if the object changed its class.</summary> 
    class State()
    {
        public int StateValue = 0;
        public void StateWork()
        {
            if (this.StateValue == 0)
            {
                Console.WriteLine("State is 0!");
            }
            else
            {
                Console.WriteLine("State is not 0!");
            }
        }
    }
}