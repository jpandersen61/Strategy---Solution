using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public interface IObserver
    {
        void Notify(IMenu menu);
    }
}
