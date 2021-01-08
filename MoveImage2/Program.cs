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
            ColorForConsole consColor = new ColorForConsole(foregroundColor);
            consColor.GetConsoleColor();

            Console.Write("Choose your image type(1-Rectangle, 2-Triangle): ");
            string str = Console.ReadLine();
            int.TryParse(str, out int type);
            IFigureBuilder figureBuilder;
            if (type == (int)Figures.Rectangle)
            {
                figureBuilder = new RectangleBuilder();
                figureBuilder.Create();
            }
            else if (type == (int)Figures.Triangle)
            {
                figureBuilder = new TriangleBuilder();
                figureBuilder.Create();
            }
            else
            {
                Console.WriteLine("There is no such type.");
            }
        }
    }
}