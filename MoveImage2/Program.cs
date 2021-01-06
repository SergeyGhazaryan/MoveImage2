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

            string foregrcolor = Console.ReadLine();
            Color consColor = new Color(foregrcolor);
            consColor.GetConsoleColor();

            Console.Write("Choose your image type(1-Rectangle, 2-Triangle): ");
            int type = Convert.ToInt32(Console.ReadLine());
            if (type == 1)
            {
                RectangleBuilder rectangleBuilder = new RectangleBuilder();
                rectangleBuilder.CreateRectangle(type);
            }
            else if (type == 2)
            {
                TriangleBuilder triangleBuilder = new TriangleBuilder();
                triangleBuilder.CreateTriangle(type);
            }
            else
            {
                Console.WriteLine("There is no such type.");
            }
        }
    }
}