using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public interface IPriceStrategy
    {
        public  double CalculatePrice(IMenu menu);
    }
}
