using System;
using System.Collections.Generic;

namespace Graphics
{
    // "Composite"
    class CompositeGraphic : IGraphic
    {
        private List<IGraphic> _children = new List<IGraphic>();

        public void Draw()
        {
            _children.ForEach(graphic => graphic.Draw());
        }

        public virtual void Add(IGraphic graphic)
        {
            _children.Add(graphic);
        }

        public virtual void Remove(IGraphic graphic)
        {
            _children.Remove(graphic);
        }
    }
}
