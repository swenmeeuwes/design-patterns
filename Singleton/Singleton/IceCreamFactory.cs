using System;

namespace Singleton
{
    class IceCreamFactory : LazySingleton<IceCreamFactory>
    {
        public IceCream Create(IceCreamType type)
        {
            switch (type)
            {
                case IceCreamType.Vanilla:
                    return new VanillaIceCream();
            }

            throw new ArgumentOutOfRangeException();
        }
    }
}
