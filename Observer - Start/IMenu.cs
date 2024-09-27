using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public interface IMenu
    {
        public string Drink { get; }
        public double MenuPrice { get;}

        public AbstractPizza Pizza {get;}
    }
}
