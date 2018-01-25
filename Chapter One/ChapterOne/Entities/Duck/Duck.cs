using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapterOne.Interfaces;

namespace ChapterOne.Entities.Duck
{
    public abstract class Duck
    {
        private static IFlyBehavior flyBehavior;
        private static IQuackBehavior quackBehavior;

        public Duck()
        {
            flyBehavior.Fly();
            quackBehavior.Quack();
        }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void Swim() {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
