using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Entities
{
    class UnsupportedOperationException : Exception
    {
        public UnsupportedOperationException(string Message) : base(Message)
        {
        }
    }
}
