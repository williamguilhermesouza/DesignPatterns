using System;

namespace Behavioral 
{
    class Behavioral
    {
        static void Main(string[] args)
        {
            if (args.Length < 1) return;
            if (args[0] == "State")
            {
                State state = new State();
                state.StateWork();
                state.StateValue = 1;
                state.StateWork();
            }
        }
    }
}