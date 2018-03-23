using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterFour.Entities
{
    class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";
            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
