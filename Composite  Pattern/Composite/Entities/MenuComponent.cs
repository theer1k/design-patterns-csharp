using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Entities
{
    abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new InvalidOperationException();
        }

        public virtual MenuComponent GetChild(int i)
        {
              throw new InvalidOperationException();
        }

        public virtual String GetName()
        {
              throw new InvalidOperationException();
        }

        public virtual String GetDescription()
        {
              throw new InvalidOperationException();
        }

        public virtual double GetPrice()
        {
              throw new InvalidOperationException();
        }
        public virtual Boolean IsVegetarian()
        {
              throw new InvalidOperationException();
        }

        public virtual void Print()
        {
              throw new InvalidOperationException();
        }
    }
}
