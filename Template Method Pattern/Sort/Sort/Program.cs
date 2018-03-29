using System;
using System.Collections;
using Sort.Entities;
namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck[] ducks = {
                        new Duck("Daffy", 8),
                        new Duck("Dewey", 2),
                        new Duck("Howard", 7),
                        new Duck("Louie", 2),
                        new Duck("Donald", 10),
                        new Duck("Huey", 2)
         };

            Console.WriteLine("Before sorting:");
            Display(ducks);

            Array.Sort(ducks);

            Console.WriteLine("\nAfter sorting:");
            Display(ducks);

            Console.ReadLine();
        }

        public static void Display(Duck[] ducks)
        {
            foreach (Duck d in ducks)
            {
                Console.WriteLine(d);
            }
        }
    }
}
