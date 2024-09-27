using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class PizzaFactory : IPizzaFactory
    {


        public AbstractPizza MakePizza(string[] additionals)
        {
            AbstractPizza pizza = new PizzaMargaritta(); ;
            if (additionals != null)
                foreach (var ingredients in additionals)
                {
                    pizza = AddIngredients(ingredients, pizza);
                }
            return pizza;
        }

        private AbstractPizza AddIngredients(string ingredients, AbstractPizza pizza)
        {
            switch (ingredients)
            {
                case "Ham": return new HamDecorator(pizza);
                case "Pepperoni": return new PepperoniDecorator(pizza);
                case "Bacon": return new BaconDecorator(pizza);
                case "Chilli": return new ChilliDecorator(pizza);
                default: return pizza;
            }
        }
    }
}
