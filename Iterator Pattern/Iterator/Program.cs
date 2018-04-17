using Iterator.Entities;
using System;
using System.Collections.Generic;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();

            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);

            waitress.PrintMenu();
            PrintMenu();
            Console.ReadLine();
        }

        public static void PrintMenu()
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();

            List<MenuItem> breakfastItems = pancakeHouseMenu.GetMenuItems();
            MenuItem[] lunchItems = dinerMenu.GetMenuItems();

            Console.WriteLine("USING FOR EACH");

            foreach (MenuItem menuItem in breakfastItems)
            {
                Console.WriteLine(menuItem.GetName());
                Console.WriteLine("\n" + menuItem.GetPrice());
                Console.WriteLine("\n" + menuItem.GetDescription());
            }
            foreach (MenuItem menuItem in lunchItems)
            {
                Console.WriteLine(menuItem.GetName());
                Console.WriteLine("\n" + menuItem.GetPrice());
                Console.WriteLine("\n" + menuItem.GetDescription());
            }

            Console.WriteLine("USING FOR LOOPS");
            for (int i = 0; i < breakfastItems.Count; i++)
            {
                MenuItem menuItem = (MenuItem)breakfastItems[i];
                Console.WriteLine(menuItem.GetName());
                Console.WriteLine("\n" + menuItem.GetPrice());
                Console.WriteLine("\n" + menuItem.GetDescription());
            }

            for (int i = 0; i < lunchItems.Length; i++)
            {
                MenuItem menuItem = lunchItems[i];
                Console.WriteLine(menuItem.GetName());
                Console.WriteLine("\n" + menuItem.GetPrice());
                Console.WriteLine("\n" + menuItem.GetDescription());
            }
        }
    }
}
