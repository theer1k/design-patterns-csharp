using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterFour.Entities
{
    public abstract class Pizza
    {
        public String name;
        public String dough;
        public String sauce;
        public ArrayList toppings = new ArrayList();

        public void Prepare()
        {
            Console.WriteLine("Preparing + {0}", name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            for (int i = 0; i < toppings.Count; i++)
            {
                Console.WriteLine(" " + toppings[i]);
            }
        }

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
    }
}
