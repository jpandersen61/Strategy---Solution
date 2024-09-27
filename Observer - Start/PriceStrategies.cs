using PizzaApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class EveningPriceStrategy : IPriceStrategy
    {
        public  double CalculatePrice(IMenu menu)
        {
            return menu.MenuPrice;
        }
    }

    public class LunchPriceStrategy : IPriceStrategy
    {
       

        public  double CalculatePrice(IMenu menu)
        {
            return menu.MenuPrice*0.8;
        }
    }

    public class NightPriceStrategy : IPriceStrategy
    {
        public  double CalculatePrice(IMenu menu)
        {
            return menu.MenuPrice * 1.1;
        }
    }
}
