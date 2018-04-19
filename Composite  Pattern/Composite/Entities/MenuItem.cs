using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Entities
{
    class MenuItem : MenuComponent
    {
        String name;
        String description;
        Boolean vegetarian;
        double price;

        public MenuItem(String name,
                        String description,
                        Boolean vegetarian,
                        double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public override String GetName()
        {
            return name;
        }

        public override String GetDescription()
        {
            return description;
        }

        public override double GetPrice()
        {
            return price;
        }

        public override Boolean IsVegetarian()
        {
            return vegetarian;
        }

        public override void Print()
        {
            Console.Write(GetName());
            if (IsVegetarian())
            {
                Console.Write("(v),");
            }
            Console.WriteLine(" " + GetPrice());
            Console.WriteLine("     -- " + GetDescription());
        }
    }
}
