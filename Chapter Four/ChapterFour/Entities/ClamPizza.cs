using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapterFour.Interfaces;

namespace ChapterFour.Entities
{
    class ClamPizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            clam = ingredientFactory.CreateClam();
        }
    }
}
