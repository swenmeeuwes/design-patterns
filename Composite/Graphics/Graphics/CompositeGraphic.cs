using System;
using System.Collections.Generic;

namespace Graphics
{
    class CompositeGraphic : IGraphic
    {
        private List<IGraphic> _children = new List<IGraphic>();

        public void Draw()
        {
            // The iterator pattern could be of use here
            // But we'll focus on the composite pattern for now
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

        public virtual IGraphic GetChildAt(int index)
        {
            if (index >= _children.Count)
                throw new ArgumentOutOfRangeException();

            return _children[index];
        }
    }
}
