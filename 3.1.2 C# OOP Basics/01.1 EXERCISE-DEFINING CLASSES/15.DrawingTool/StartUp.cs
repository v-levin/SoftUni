using System;

namespace DrawingTool
{
    public class StartUp
    {
        public static void Main()
        {
            var figure = Console.ReadLine();

            CorDraw corDraw;
            switch (figure)
            {
                case "Square":
                    var size = int.Parse(Console.ReadLine());
                    corDraw = new CorDraw(new Square(size));
                    corDraw.Square.Draw();
                    break;
                case "Rectangle":
                    var width = int.Parse(Console.ReadLine());
                    var height = int.Parse(Console.ReadLine());
                    corDraw = new CorDraw(new Rectangle(width, height));
                    corDraw.Rectangle.Draw();
                    break;
            }
        }
    }
}
