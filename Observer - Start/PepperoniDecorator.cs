using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class PepperoniDecorator : AbstractPizzaDecorator
    {

        public PepperoniDecorator(AbstractPizza pizza)
        {
            Pizza = pizza;
            Price = Pizza.Price + 5;
            Ingredients = Pizza.Ingredients + " and Pepperoni";
        }

        public override string ToString()
        {
            return "Pizza with " + Ingredients;
        }

    }
}
