using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapterOne.Entities;
using ChapterOne.Entities.Quackable;
using ChapterOne.Entities.Flyable;

namespace ChapterOne.Entities.Duck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            MallardDuck.QuackBehavior = new NormalQuack();
            MallardDuck.FlyBehavior = new FlyWithWings();
        }

        public override void Display() {
            Console.WriteLine("I'm a real Mallard duck");
        } 
    }
}

