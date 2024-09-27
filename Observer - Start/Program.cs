using System;

namespace PizzaApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            PizzaOven pizzaOven = new PizzaOven();
            PizzaMan pizzaMan = new PizzaMan(pizzaOven);

            Console.WriteLine("Pizza order: Ham and Bacon");
            string[] order = { "Ham", "Bacon" };
            pizzaMan.TakeOrder(order);

            Console.WriteLine();

            Console.WriteLine("Pizza order: Ham and Pepperoni");
            string[] order2 = { "Ham", "Pepperoni" };

            //Add a drink e.g. a Coke to the order 
            pizzaMan.TakeOrder(order2, "Coke", 25);

            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
