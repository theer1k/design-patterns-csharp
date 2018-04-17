using Iterator.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Entities
{
    class PancakeHouseMenuIterator : IIterator
    {
        List<MenuItem> items = new List<MenuItem>();
        int position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> items)
        {
            this.items = items;
        }

        public MenuItem Next()
        {
            MenuItem item = items[position];
            position = position + 1;
            return item;
        }

        public Boolean HasNext()
        {
            if (position >= items.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
