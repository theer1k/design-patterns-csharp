using System;
using System.Collections.Generic;
using System.Text;

namespace ChapterEight.Entities
{
    public abstract class CaffeineBeverage
    {
        public virtual void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();

            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public virtual Boolean CustomerWantsCondiments()
        {
            return true;
        }
    }
}
