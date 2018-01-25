using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapterOne.Entities;
using ChapterOne.Entities.Quack;
using ChapterOne.Entities.Fly;
using ChapterOne.Interfaces;

namespace ChapterOne.Entities.Duck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            IQuackBehavior QuackBehavior = new NormalQuack();
            IFlyBehavior FlyBehavior = new FlyWithWings();
        }

        public override void Display() {
            Console.WriteLine("I'm a real Mallard duck");
        } 
    }
}

