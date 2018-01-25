using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapterOne.Interfaces;

namespace ChapterOne.Entities.Fly
{
    class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm can't fly");
        }
    }
}
