using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapterFour.Entities;

namespace ChapterFour.Entities
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(String type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
        protected abstract Pizza CreatePizza(String type);
    }
}
