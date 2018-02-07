namespace PizzaToppings
{
    // "Concrete decorator"
    class TomatoSauce : Topping
    {
        public override double Cost => base.Cost + 2.35d;
        public override string Description => $"{base.Description}, tomato sauce";

        public TomatoSauce(IFood component) : base(component)
        {
            
        }
    }
}
