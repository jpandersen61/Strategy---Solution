using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public abstract class AbstractPizza
    {
        public string Ingredients { get; set; }
        public double Price { get; set; }
    }
}
