using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Entities
{
    class GumballMonitor
    {
        GumballMachine machine;

        public GumballMonitor(GumballMachine machine)
        {
            this.machine = machine;
        }

        public void Report()
        {
            Console.WriteLine("Gumball Machine: " + machine.GetLocation());
            Console.WriteLine("Current inventory: " + machine.GetCount() + " gumballs");
            Console.WriteLine("Current state: " + machine.GetState());
        }
    }
}
