using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterThree.Entities
{
    class HouseBlend : Bevarage
    {
        public override string Description
        {
            get { return "House Blend Coffee"; }
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
