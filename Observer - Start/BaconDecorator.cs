using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class BaconDecorator : AbstractPizzaDecorator
    {

        public BaconDecorator(AbstractPizza pizza)
        {
            Pizza = pizza;
            Price = Pizza.Price + 7;
            Ingredients = Pizza.Ingredients + " and Bacon";
        }

        public override string ToString()
        {
            return "Pizza with " + Ingredients;
        }
    }
}
