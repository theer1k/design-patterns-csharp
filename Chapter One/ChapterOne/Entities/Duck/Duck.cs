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
        protected static IFlyBehavior FlyBehavior;
        protected static IQuackBehavior QuackBehavior;

        public Duck()
        {
        }

        public abstract void Display();

        public void PerformFly()
        {
             FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
             QuackBehavior.Quack();
        }

        public void Swim() {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
