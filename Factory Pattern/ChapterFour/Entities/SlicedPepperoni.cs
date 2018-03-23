using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapterFour.Interfaces;

namespace ChapterFour.Entities
{
    class SlicedPepperoni: IPepperoni
    {
        public override String ToString()
        {
            return "Sliced Pepperoni";
        }
    }
}
