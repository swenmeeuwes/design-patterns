namespace PizzaToppings
{
    // "Concrete decorator"
    class Mozzarella : Topping
    {
        public override double Cost => base.Cost + 2.15d;
        public override string Description => $"{base.Description}, mozzarella";

        public Mozzarella(IFood component) : base(component)
        {

        }
    }
}
