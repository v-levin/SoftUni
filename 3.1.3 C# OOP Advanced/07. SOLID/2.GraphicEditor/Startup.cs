namespace GraphicEditor
{
    public class Startup
    {
        public static void Main()
        {
            IShape rectangle = new Rectangle();
            IShape circle = new Circle();
            IShape square = new Square();

            var graphicEditor = new GraphicEditor();

            graphicEditor.DrawShape(rectangle);
            graphicEditor.DrawShape(circle);
            graphicEditor.DrawShape(square);
        }
    }
}
