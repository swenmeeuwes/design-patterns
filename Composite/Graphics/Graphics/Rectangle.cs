using System;

namespace Graphics
{
    // "Leaf"
    class Rectangle : IGraphic
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
}
