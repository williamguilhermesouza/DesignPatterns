﻿using System;

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
            else if (args[0] == "COR")
            {
                var obj = new ChainOfResponsibility.FirstOfChainOfResponsibility(0);
                Console.WriteLine(obj.FirstProperty);
            }
			else if(args[0] == "Command")
			{
				var button = new Command.Button();
				var menuItem = new Command.MenuItem();
				var shortcut = new Command.Shortcut();

				button.Save("Button");
				menuItem.Save("MenuItem");
				shortcut.Save("Shortcut");
			}
			else if(args[0] == "Iterator")
			{
				var el1 = new Iterator.Element(1);
				var el2 = new Iterator.Element(1);
				var el3 = new Iterator.Element(1);
				var el4 = new Iterator.Element(1);
				el1.Next = el2;
				el2.Next = el3;
				el3.Next = el4;
				var listing = new Iterator.ListIterator(el1);
				Console.WriteLine(listing.Size());
			}
        }
    }
}