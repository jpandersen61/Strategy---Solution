using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class ChilliDecorator : AbstractPizzaDecorator
    {
        public ChilliDecorator(AbstractPizza pizza)
        {
            Pizza = pizza;
            Price = Pizza.Price + 5;
            Ingredients = Pizza.Ingredients + " and Chilli";
        }

        public override string ToString()
        {
            return "Pizza with " + Ingredients;
        }

    }
}
