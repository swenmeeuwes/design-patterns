using System;

namespace PizzaToppings
{
    // "Client"
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaMargarita = new Mozzarella(
                new TomatoSauce(
                    new PizzaBase()
                )
            );

            var pizzaPepperoni = new Pepperoni(pizzaMargarita, 12);

            Console.WriteLine("Pizza margarita costs {0:#,##0.00} euro and consists of {1}.", pizzaMargarita.Cost, pizzaMargarita.Description);
            Console.WriteLine("Pizza pepperoni costs {0:#,##0.00} euro and consists of {1}.", pizzaPepperoni.Cost, pizzaPepperoni.Description);
        }
    }
}
