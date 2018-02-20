using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapterFour.Entities;
namespace ChapterFour
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            Pizza pizza = nyStore.orderPizza("cheese");
            Console.WriteLine("Ethan ordered a {0}", pizza.GetName());
            Console.ReadLine();
        }
    }
}
