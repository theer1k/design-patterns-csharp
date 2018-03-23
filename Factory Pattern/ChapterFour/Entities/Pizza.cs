using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapterFour.Interfaces;

namespace ChapterFour.Entities
{
    public abstract class Pizza
    {
        public String name;
   
        public IDough dough;
        public ISauce sauce;
        public IVeggies[] veggies;
        public ICheese cheese;
        public IPepperoni pepperoni;
        public IClams clam;

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box”");
        }

        public String GetName()
        {
            return name;
        }

       public void SetName(String name)
        {
            this.name = name;
        }

        public override String ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("---- " + name + " ----\n");
            result.Append(dough + "\n");
            result.Append(sauce + "\n");
            if (dough != null)
            {
                result.Append(dough);
                result.Append("\n");
            }
            if (sauce != null)
            {
                result.Append(sauce);
                result.Append("\n");
            }
            if (cheese != null)
            {
                result.Append(cheese);
                result.Append("\n");
            }
            if (veggies != null)
            {
                for (int i = 0; i < veggies.Length; i++)
                {
                    result.Append(veggies[i]);
                    if (i < veggies.Length - 1)
                    {
                        result.Append(", ");
                    }
                }
                result.Append("\n");
            }
            if (clam != null)
            {
                result.Append(clam);
                result.Append("\n");
            }
            if (pepperoni != null)
            {
                result.Append(pepperoni);
                result.Append("\n");
            }
            return result.ToString();
        }
    }
}
