namespace PizzaToppings
{
    // "Decorator"
    abstract class Topping : IFood
    {
        public virtual double Cost => _component.Cost;
        public virtual string Description => _component.Description;

        private IFood _component;

        public Topping(IFood component)
        {
            _component = component;
        }
    }
}
