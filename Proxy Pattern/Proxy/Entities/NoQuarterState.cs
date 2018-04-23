using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Entities
{
    class NoQuarterState : State
    {
        GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public override void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            gumballMachine.SetState(gumballMachine.GetHasQuarterState());
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public override void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }

        public override void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public override String ToString()
        {
            return "waiting for quarter";
        }
    }
}
