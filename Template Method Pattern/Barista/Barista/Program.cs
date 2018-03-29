using System;
using ChapterEight.Entities;

namespace Barista
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            Coffee coffee = new Coffee();

            Console.WriteLine("\nMaking tea...");
            tea.PrepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffee.PrepareRecipe();

            Console.ReadLine();
        }
    }
}
