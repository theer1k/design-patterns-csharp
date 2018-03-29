using System;
using System.Collections.Generic;
using System.Text;

namespace ChapterEight.Entities
{
    class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override Boolean CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like lemon with your tea (y/n)? ");

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
