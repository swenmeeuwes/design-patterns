using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var iceCream = IceCreamFactory.Instance.Create(IceCreamType.Vanilla);
        }
    }
}
