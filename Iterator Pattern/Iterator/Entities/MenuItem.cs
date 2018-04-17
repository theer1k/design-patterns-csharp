using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Entities
{
    class MenuItem
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

        public String GetName()
        {
            return name;
        }

        public String GetDescription()
        {
            return description;
        }

        public double GetPrice()
        {
            return price;
        }

        public Boolean IsVegetarian()
        {
            return vegetarian;
        }
        public override String ToString()
        {
            return (name + ", $" + price + "\n   " + description);
        }
    }
}
