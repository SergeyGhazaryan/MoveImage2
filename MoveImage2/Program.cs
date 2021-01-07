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
            IBuilderImage builderImage;
            if (type == 1) //rectangle
            {
                builderImage = new RectangleBuilder();
                builderImage.Create();
            }
            else if (type == 2) //triangle
            {
                builderImage = new TriangleBuilder();
                builderImage.Create();
            }
            else
            {
                Console.WriteLine("There is no such type.");
            }
        }
    }
}