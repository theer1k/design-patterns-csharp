using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Entities
{
    class Menu : MenuComponent
    {
        List<MenuComponent> menuComponents = new List<MenuComponent>();
        String name;
        String description;

        public Menu(String name, String description)
        {
            this.name = name;
            this.description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return (MenuComponent)menuComponents[i];
        }

        public override String GetName()
        {
            return name;
        }

        public override String GetDescription()
        {
            return description;
        }

        public override void Print()
        {
            Console.WriteLine("\n {0}, {1} ", GetName(), GetDescription());
            Console.WriteLine("---------------------");

            IEnumerator<MenuComponent> iterator = menuComponents.GetEnumerator();
            while (iterator.MoveNext())
            {
                MenuComponent menuComponent =
                    (MenuComponent)iterator.Current;
                menuComponent.Print();
            }
        }
    }
}
