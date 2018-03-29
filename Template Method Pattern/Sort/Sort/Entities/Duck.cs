using System;
using System.Collections.Generic;
using System.Text;

namespace Sort.Entities
{
    class Duck : IComparable<Duck>
    {
        String name;
        int weight;

        public Duck(String name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public override String ToString()
        {
            return name + " weighs " + weight;
        }

        public int CompareTo(Duck o)
        {

            Duck otherDuck = o;

            if (this.weight < otherDuck.weight)
            {
                return -1;
            }
            else if (this.weight == otherDuck.weight)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
