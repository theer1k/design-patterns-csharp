using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapterFive.Entities;

namespace ChapterFive
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler chocolateBoiler = new ChocolateBoiler();
            chocolateBoiler.GetInstance();
            chocolateBoiler.Fill();
            chocolateBoiler.Boil();
            chocolateBoiler.Drain();

            Console.ReadLine();
        }
    }
}
