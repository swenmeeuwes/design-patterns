namespace Graphics
{
    class Program
    {
        static void Main(string[] args)
        {
            var compositeGraphic = new CompositeGraphic();
            compositeGraphic.Add(new Ellipse());
            compositeGraphic.Add(new Rectangle());

            var anotherCompositeGraphic = new CompositeGraphic();
            anotherCompositeGraphic.Add(new Ellipse());
            anotherCompositeGraphic.Add(compositeGraphic);

            anotherCompositeGraphic.Draw();
        }
    }
}
