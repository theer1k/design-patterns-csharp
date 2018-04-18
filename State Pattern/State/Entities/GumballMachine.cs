using System;
using System.Collections.Generic;
using System.Text;
using State.Interfaces;

namespace State.Entities
{
    class GumballMachine
    {

        IState soldOutState;
        IState noQuarterState;
        IState hasQuarterState;
        IState soldState;

        IState state;
        int count = 0;

        public GumballMachine(int numberGumballs)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);

            this.count = numberGumballs;
            if (numberGumballs > 0)
            {
                state = noQuarterState;
            }
            else
            {
                state = soldOutState;
            }
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            state.EjectQuarter();
        }

        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (count != 0)
            {
                count = count - 1;
            }
        }

        public int GetCount()
        {
            return count;
        }

        public void Refill(int count)
        {
            this.count += count;
            Console.WriteLine("The gumball machine was just refilled; it's new count is: " + this.count);
            state.Refill();
        }

        public void SetState(IState state)
        {
            this.state = state;
        }
        public IState GetState()
        {
            return state;
        }

        public IState GetSoldOutState()
        {
            return soldOutState;
        }

        public IState GetNoQuarterState()
        {
            return noQuarterState;
        }

        public IState GetHasQuarterState()
        {
            return hasQuarterState;
        }

        public IState GetSoldState()
        {
            return soldState;
        }

        public override String ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\nMighty Gumball, Inc.");
            result.Append("\nJava-enabled Standing Gumball Model #2004");
            result.Append("\nInventory: " + count + " gumball");
            if (count != 1)
            {
                result.Append("s");
            }
            result.Append("\n");
            result.Append("Machine is " + state + "\n");
            return result.ToString();
        }
    }
}
