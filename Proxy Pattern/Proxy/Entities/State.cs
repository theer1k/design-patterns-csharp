using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Proxy.Entities
{
    [Serializable]
     abstract class State
    {
        public virtual void InsertQuarter() { }

        public virtual void EjectQuarter() { }

        public virtual void TurnCrank() { }

        public virtual void Dispense() { }
    }
}
