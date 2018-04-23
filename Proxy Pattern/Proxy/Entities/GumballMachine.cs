using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Entities
{
    class GumballMachine
    {
        static State soldOutState;
        State noQuarterState;
        State hasQuarterState;
        State soldState;
        State winnerState;

        State state = soldOutState;
        int count = 0;
        String location;

        public GumballMachine(String location, int count)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);

            this.count = count;
            if (count > 0)
            {
                state = noQuarterState;
            }
            this.location = location;
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

        public void SetState(State state)
        {
            this.state = state;
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
            this.count = count;
            state = noQuarterState;
        }

        public State GetState()
        {
            return state;
        }

        public String GetLocation()
        {
            return location;
        }

        public State GetSoldOutState()
        {
            return soldOutState;
        }

        public State GetNoQuarterState()
        {
            return noQuarterState;
        }

        public State GetHasQuarterState()
        {
            return hasQuarterState;
        }

        public State GetSoldState()
        {
            return soldState;
        }

        public State GetWinnerState()
        {
            return winnerState;
        }

        public override String ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\nMighty Gumball, Inc.");
            result.Append("\nStanding Gumball Model #2004");
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
