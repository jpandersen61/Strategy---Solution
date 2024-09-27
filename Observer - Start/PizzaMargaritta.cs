using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class PizzaMargaritta : AbstractPizza
    {
        public override string ToString()
        {
            return "Pizza with " + Ingredients;
        }


        public PizzaMargaritta()
        {
            Price = 50;
            Ingredients = "Tomatoes and cheese";
        }

    }
}
