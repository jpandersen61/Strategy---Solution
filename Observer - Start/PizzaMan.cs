using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{


public enum TimeOfDay { Lunch, Evening, Night };
    
public class PizzaMan : IObserver
    {
        public IPizzaFactory PizzaFactory { get; set; }
        public PizzaOven PizzaOven { get; set; }
       
        

        public PizzaMan(PizzaOven pizzaOven)
        {
            /*
                 We need a PizzaFactory together with the PizzaOven.
                 PizzaMan should also be able to observe the PizzaOven
            */

            this.PizzaOven = pizzaOven;
            PizzaOven.AddObserver(this);
            PizzaFactory = new PizzaFactory();
            
        }

        public void TakeOrder(String[] additionals)
        {
            /*
                 Make use of a PizzaFactory and a PizzaOven
            */

            AbstractPizza pizza = PizzaFactory.MakePizza(additionals);
           
            PizzaOven.preparePizza(new PizzaToMenuAdapter(pizza));
        }

        public void TakeOrder(String[] additionals, string drink, double drinkPrice)
        {
            /*
                 Make use of a PizzaFactory and a PizzaOven
            */

            AbstractPizza pizza = PizzaFactory.MakePizza(additionals);
            PizzaOven.preparePizza(new PizzaToMenuAdapter(pizza,drink,drinkPrice));
        }

        public void Notify(IMenu menu)
        {
            /*
                 Let PizzaMan announce that the pizza is ready.
                 Specific information including price should be 
                 announced
            */
            TimeOfDay DayTime = TimeOfDay.Lunch;
            double price = 0.0;

            switch (DayTime)
            {
                 case TimeOfDay.Evening: price = new EveningPriceStrategy().CalculatePrice(menu); break;
                 case TimeOfDay.Lunch: price = new LunchPriceStrategy().CalculatePrice(menu); break;
                 case TimeOfDay.Night: price = new NightPriceStrategy().CalculatePrice(menu); break;

            }
            

    Console.WriteLine($"Pizza is ready: {menu}, discounted price {price}");
            
        }
    }
}
