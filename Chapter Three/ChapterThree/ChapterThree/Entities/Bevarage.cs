using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterThree.Entities
{
    abstract class Bevarage
    {
        string description = "Unknown Bevarage";

        public virtual string Description {
            get { return description; }
        }

        public abstract double Cost();
    }
}
