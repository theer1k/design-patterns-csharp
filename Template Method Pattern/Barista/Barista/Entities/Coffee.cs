using System;
using System.Collections.Generic;
using System.Text;

namespace ChapterEight.Entities
{
    class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override Boolean CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");

            String answer = Console.ReadLine();

            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
