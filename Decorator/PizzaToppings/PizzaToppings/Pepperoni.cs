namespace PizzaToppings
{
    // "Concrete decorator"
    class Pepperoni : Topping
    {
        public override double Cost => base.Cost + 3.05d;
        public override string Description => $"{base.Description}, {_amountOfSlices} slices of pepperoni";

        private int _amountOfSlices;

        public Pepperoni(IFood component, int amountOfSlices) : base(component)
        {
            _amountOfSlices = amountOfSlices;
        }
    }
}
