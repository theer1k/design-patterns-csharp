using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterOne.Entities.Duck
{
    class ModelDuck : Duck
    {
        public ModelDuck() {
            FlyBehavior = new Flyable.FlyNoWay();
            QuackBehavior = new Quackable.NormalQuack();
        }

        public override void Display() {
            Console.WriteLine("I'm a model duck");
        } 
    }
}
