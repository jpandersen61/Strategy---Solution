using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public interface IPizzaFactory
    {
        AbstractPizza MakePizza(string[] additionals);
    }
}
