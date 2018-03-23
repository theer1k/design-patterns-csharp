using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapterSeven.Interfaces;

namespace ChapterSeven.Entities
{
    class TurkeyAdapter : IDuck
    {
        ITurkey turkey;
        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Quack()
        {
            turkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.Fly();
            }
        }

    }
}
