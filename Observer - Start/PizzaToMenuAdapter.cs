using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class PizzaToMenuAdapter : IMenu
    {
        public string Drink { get; private set; }
        public double MenuPrice { get; private set; }
        public AbstractPizza Pizza { get; private set;}

        public PizzaToMenuAdapter(AbstractPizza pizza, string drink="no drink", double drinkPrice=0.0 )
        {
            Pizza = pizza;
            Drink = drink;
            MenuPrice = drinkPrice + Pizza.Price;
        }

        public override string ToString()
        {
            return $"{Pizza} with a {Drink}. Menu price: {MenuPrice}" ;
        }
    }
}
