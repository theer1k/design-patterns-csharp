using System;
using System.Collections.Generic;
using System.Text;
using Iterator.Interfaces;

namespace Iterator.Interfaces
{
    interface IMenu
    {
        IIterator CreateIterator();
    }
}
