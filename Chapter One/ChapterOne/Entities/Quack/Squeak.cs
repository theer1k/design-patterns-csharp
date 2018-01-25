using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapterOne.Interfaces;

namespace ChapterOne.Entities.Quack
{
    class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
