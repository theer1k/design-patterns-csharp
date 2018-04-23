using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Entities
{
    class HasQuarterState : State
    {
        Random randomWinner = new Random();
        GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public override void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }

        public override void TurnCrank()
        {
            Console.WriteLine("You turned...");
            int winner = randomWinner.Next(10);
            if (winner == 0)
            {
                gumballMachine.SetState(gumballMachine.GetWinnerState());
            }

            else
            {
                gumballMachine.SetState(gumballMachine.GetSoldState());
            }
        }

        public override void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public override String ToString()
        {
            return "waiting for turn of crank";
        }
    }
}
