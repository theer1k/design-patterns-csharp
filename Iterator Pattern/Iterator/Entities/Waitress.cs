using Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Entities
{
    class Waitress
    {
        IMenu pancakeHouseMenu;
        IMenu dinerMenu;

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            IIterator pancakeIterator = pancakeHouseMenu.CreateIterator();
            IIterator dinerIterator = dinerMenu.CreateIterator();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            printMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            printMenu(dinerIterator);

        }

        private void printMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();
                Console.WriteLine(menuItem.GetName() + ", ");
                Console.WriteLine(menuItem.GetPrice() + " -- ");
                Console.WriteLine(menuItem.GetDescription());
            }
        }

        public void PrintVeGetarianMenu()
        {
            PrintVeGetarianMenu(pancakeHouseMenu.CreateIterator());
            PrintVeGetarianMenu(dinerMenu.CreateIterator());
        }

        public Boolean IsItemVeGetarian(String name)
        {
            IIterator breakfastIterator = pancakeHouseMenu.CreateIterator();
            if (IsVegetarian(name, breakfastIterator))
            {
                return true;
            }

            IIterator dinnerIterator = dinerMenu.CreateIterator();
            if (IsVegetarian(name, dinnerIterator))
            {
                return true;
            }
            return false;
        }


        private void PrintVeGetarianMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();
                if (menuItem.IsVegetarian())
                {
                    Console.WriteLine(menuItem.GetName());
                    Console.WriteLine("\t\t" + menuItem.GetPrice());
                    Console.WriteLine("\t" + menuItem.GetDescription());
                }
            }
        }

        private Boolean IsVegetarian(String name, IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();
                if (menuItem.GetName().Equals(name))
                {
                    if (menuItem.IsVegetarian())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
