using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);
    }
}
