using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapterOne.Entities.Duck;

namespace ChapterOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();
            Console.ReadLine();
        }
    }
}
