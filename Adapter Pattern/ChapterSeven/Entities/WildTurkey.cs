using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapterSeven.Interfaces;

namespace ChapterSeven.Entities
{
    class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }
        public void Fly()
        {
            Console.WriteLine("I’m flying a short distance");
        }
    }
}
