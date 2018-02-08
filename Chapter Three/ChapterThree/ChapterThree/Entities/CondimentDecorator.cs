using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterThree.Entities
{
    abstract class CondimentDecorator : Bevarage
    {
        public abstract override string Description { get; }
    }
}
