namespace PizzaToppings
{
    // "Concrete component"
    class PizzaBase : IFood
    {
        public double Cost => 3.20d;
        public string Description => "a pizza base";
    }
}
