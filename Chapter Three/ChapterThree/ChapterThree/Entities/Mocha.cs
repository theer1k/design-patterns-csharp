using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterThree.Entities
{
    class Mocha : CondimentDecorator
    {
        Bevarage bevarage;

        public Mocha(Bevarage bevarage)
        {
            this.bevarage = bevarage;
        }

        public override string Description
        {
            get{ return bevarage.Description + ", Mocha"; }
        }

        public override double Cost()
        {
            return (.20 + bevarage.Cost());
        }
    }
}
