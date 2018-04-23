using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Entities
{
    class SoldState : State
    {
        GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public override void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public override void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }

        public override void Dispense()
        {
            gumballMachine.ReleaseBall();
            try
            {
                if (gumballMachine.GetCount() > 0)
                {
                    gumballMachine.SetState(gumballMachine.GetNoQuarterState());
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    gumballMachine.SetState(gumballMachine.GetSoldOutState());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public override String ToString()
        {
            return "dispensing a gumball";
        }
    }
}
