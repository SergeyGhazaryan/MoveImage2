using System;

namespace Form
{
    class TriangleBuilder : IFigureBuilder
    {
        private IShape shape;

        public IShape Create()
        {
            bool notNumber = true;
            while (notNumber)
            {
                Console.WriteLine("Enter the side of the triangle.");
                Console.WriteLine();
                Console.Write("Sides: ");
                string s = Console.ReadLine();
                bool number = int.TryParse(s, out int sides);
                if (number)
                {
                    Console.WriteLine();
                    shape = new Triangle(sides);
                    notNumber = false;
                }
                else
                {
                    Console.WriteLine("You must enter a number.");
                }
            }
            return shape;
        }
    }
}