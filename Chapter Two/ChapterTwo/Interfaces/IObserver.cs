using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterTwo.Interfaces
{
    interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}
