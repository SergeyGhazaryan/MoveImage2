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
            Color consColor = new Color(foregroundColor);
            consColor.GetConsoleColor();

            Console.Write("Choose your image type(1-Rectangle, 2-Triangle): ");
            string str = Console.ReadLine();
            int.TryParse(str, out int type);
            IBuilder builder;
            if (type == 1)
            {
                builder = new RectangleBuilder();
                builder.Create();
            }
            else if (type == 2)
            {
                builder = new TriangleBuilder();
                builder.Create();
            }
            else
            {
                Console.WriteLine("There is no such type.");
            }
        }
    }
}