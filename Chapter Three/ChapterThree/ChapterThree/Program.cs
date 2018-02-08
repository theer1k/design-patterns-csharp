using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapterThree.Entities;

namespace ChapterThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Bevarage bevarage = new Espresso();

            Console.WriteLine("{0} ${1}", bevarage.Description, bevarage.Cost().ToString());

            bevarage = new DarkRoast();

            bevarage = new Mocha(bevarage);



            Console.WriteLine("{0} ${1}", bevarage.Description, bevarage.Cost().ToString());

            Console.ReadLine();
        }
    }
}
