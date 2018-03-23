using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapterSeven.Entities;
using ChapterSeven.Interfaces;
namespace ChapterSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says...");
            turkey.Gobble();
            turkey.Fly();
            Console.WriteLine("\nThe Duck says...");
            TestDuck(duck);

            Console.WriteLine("\nThe TurkeyAdapter says...");
            TestDuck(turkeyAdapter);

            Console.ReadLine();
        }

        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
