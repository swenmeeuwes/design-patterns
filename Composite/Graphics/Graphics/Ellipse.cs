using System;

namespace Graphics
{
    // "Leaf"
    class Ellipse : IGraphic
    {
        public void Draw()
        {
            Console.WriteLine("Drawing an ellipse");
        }
    }
}
