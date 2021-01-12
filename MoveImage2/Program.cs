using System;
using System.Text;
using Form;

namespace Form
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input console color: ");

            string foregroundColor = Console.ReadLine();
            ColorForConsole consoleColor = new ColorForConsole(foregroundColor);
            consoleColor.SelectConsoleColor();

            Console.Write("Choose your image type(1-Rectangle, 2-Triangle): ");
            string str = Console.ReadLine();
            bool selected = int.TryParse(str, out int type);
            if (selected)
            {
                IFigureBuilder figureBuilder;
                var figureType = (Figures)type;
                IShape shape;
                MoveImage moveImage;
                if (figureType == Figures.Rectangle)
                {
                    figureBuilder = new RectangleBuilder();
                    shape =  figureBuilder.Create();
                    moveImage = new MoveImage(shape);
                    moveImage.MoveImg();
                }
                else if (figureType == Figures.Triangle)
                {
                    figureBuilder = new TriangleBuilder();
                    shape = figureBuilder.Create();
                    moveImage = new MoveImage(shape);
                    moveImage.MoveImg();
                }
            }
            else if (!selected)
            {
                Console.WriteLine("There is no such type.");
            }
        }
    }
}