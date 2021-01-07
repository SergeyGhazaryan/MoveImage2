using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class TriangleBuilder : IBuilderImage
    {
        public void Create()
        {
            Console.WriteLine("Enter the side of the triangle.");
            Console.WriteLine();
            Console.Write("Sides: ");
            string s = Console.ReadLine();
            bool number = int.TryParse(s, out int sides);
            if (number)
            {
                Console.WriteLine();
                IShape shape = new Triangle(sides);
                MoveImage moveImage = new MoveImage(shape);
                moveImage.MoveImg();
            }
            else
            {
                Console.WriteLine("You must enter a number.");
            }
        }
    }
}