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
            //PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan Ordered a " + pizza + "\n");

            //pizza = chicagoStore.OrderPizza("cheese");
            //Console.WriteLine("Joel Ordered a " + pizza + "\n");

            pizza = nyStore.OrderPizza("clam");
            Console.WriteLine("Ethan Ordered a " + pizza + "\n");

            //pizza = chicagoStore.OrderPizza("clam");
            //Console.WriteLine("Joel Ordered a " + pizza + "\n");

            pizza = nyStore.OrderPizza("pepperoni");
            Console.WriteLine("Ethan Ordered a " + pizza + "\n");

            //pizza = chicagoStore.OrderPizza("pepperoni");
            //Console.WriteLine("Joel Ordered a " + pizza + "\n");

            pizza = nyStore.OrderPizza("veggie");
            Console.WriteLine("Ethan Ordered a " + pizza + "\n");

            //pizza = chicagoStore.OrderPizza("veggie");
            //Console.WriteLine("Joel Ordered a " + pizza + "\n");

            Console.ReadLine();
        }
    }
}
