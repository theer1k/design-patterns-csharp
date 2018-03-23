using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterFive.Entities
{
    public class ChocolateBoiler
    {
        private static ChocolateBoiler instance;
        private Boolean empty;
        private Boolean boiled;

        public ChocolateBoiler()
        {
            this.empty = true;
            this.boiled = false;
        }

        public void Fill()
        {
            if (this.IsEmpty())
            {
                this.empty = false;
                this.boiled = false;
                Console.WriteLine("Filling!");
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                empty = true;
                Console.WriteLine("Draining!");
            }
        }

        public void Boil()
        {
            if (!this.IsEmpty() && !this.IsBoiled())
            {
                boiled = true;
                Console.WriteLine("Boiling!");
            }
        }

        public Boolean IsEmpty()
        {
            return empty;
        }
        public Boolean IsBoiled()
        {
            return boiled;
        }

        public ChocolateBoiler GetInstance()
        {
            if (instance == null)
            {
                Console.WriteLine("Creating unique instance of Chocolate Boiler");

            }
            Console.WriteLine("Returning instance of Chocolate Boiler");
            return instance;
        }
    }
}
