using System;
using System.Collections.Generic;
using System.Text;
using Iterator.Entities;

namespace Iterator.Interfaces
{
    interface IIterator
    {
        Boolean HasNext();
        MenuItem Next();
    }
}
