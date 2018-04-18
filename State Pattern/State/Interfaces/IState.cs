using System;
using System.Collections.Generic;
using System.Text;

namespace State.Interfaces
{
    interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
        void Refill();
    }
}
