using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapterTwo.Interfaces;

namespace ChapterTwo.Entities
{
    class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject wheatherData;

        public CurrentConditionsDisplay(ISubject wheatherData)
        {
            this.wheatherData = wheatherData;
            wheatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure) {
            this.temperature = temperature;
            this.humidity = humidity;
            this.Display();
        }

        public void Display() {
            Console.WriteLine("Current conditions: {0} F degrees and {1}% humidity", temperature, humidity);
        }
    }
}
