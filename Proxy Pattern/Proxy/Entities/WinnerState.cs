using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Entities
{
    class WinnerState : State
    {
        GumballMachine gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public override void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a Gumball");
        }

        public override void EjectQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a Gumball");
        }

        public override void TurnCrank()
        {
            Console.WriteLine("Turning again doesn't get you another gumball!");
        }

        public override void Dispense()
        {
            Console.WriteLine("YOU'RE A WINNER! You get two gumballs for your quarter");
            try
            {
                gumballMachine.ReleaseBall();
                if (gumballMachine.GetCount() == 0)
                {
                    gumballMachine.SetState(gumballMachine.GetSoldOutState());
                }
                else
                {
                    gumballMachine.ReleaseBall();
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
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public override String ToString()
        {
            return "despensing two gumballs for your quarter, because YOU'RE A WINNER!";
        }
    }
}
