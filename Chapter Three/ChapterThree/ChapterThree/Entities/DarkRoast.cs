using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterThree.Entities
{
    class DarkRoast: Bevarage
    {
        public override double Cost()
        {
            return .99;
        }

        public override string Description
        {
            get { return "Dark Roast Coffee"; }
        }
    }
}
