using System;
using System.Collections.Generic;
using System.Text;
using State.Interfaces;

namespace State.Entities
{
    class HasQuarterState : IState
    {
        GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void EjectQuarter()
        {
           Console.WriteLine("Quarter returned");
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }

        public void TurnCrank()
        {
           Console.WriteLine("You turned...");
            gumballMachine.SetState(gumballMachine.GetSoldState());
        }

        public void Dispense()
        {
           Console.WriteLine("No gumball dispensed");
        }

        public void Refill() { }

        public override String ToString()
        {
            return "waiting for turn of crank";
        }
    }
}
