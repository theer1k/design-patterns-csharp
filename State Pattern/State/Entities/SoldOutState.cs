using State.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.Entities
{
    class SoldOutState : IState
    {
        GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void Refill()
        {
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }

        public override String ToString()
        {
            return "sold out";
        }
    }
}
