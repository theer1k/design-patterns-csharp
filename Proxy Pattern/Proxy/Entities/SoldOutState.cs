using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Entities
{
    class SoldOutState : State
    {
        GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public override void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public override void TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }

        public override void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public override String ToString()
        {
            return "sold out";
        }
    }
}
