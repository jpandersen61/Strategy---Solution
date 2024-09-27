using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class AbstractPizzaDecorator : AbstractPizza
    {
        public AbstractPizza Pizza {get; set; }
    }
}
