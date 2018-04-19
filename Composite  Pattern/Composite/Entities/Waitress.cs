using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Entities
{
    class Waitress
    {
        MenuComponent allMenus;

        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void PrintMenu()
        {
            allMenus.Print();
        }
    }
}
