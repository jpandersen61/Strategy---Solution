using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    class HamDecorator : AbstractPizzaDecorator
    {
        public HamDecorator(AbstractPizza pizza)
        {
            Pizza = pizza;
            Price = Pizza.Price + 5;
            Ingredients = Pizza.Ingredients + " and Ham";
        }

        public override string ToString()
        {
            return "Pizza with " + Ingredients;
        }
    }
}
