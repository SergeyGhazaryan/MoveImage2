using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class TriangleBuilder
    {
        public void CreateTriangle(int type)
        {
            Console.WriteLine("Enter the side of the triangle.");
            Console.WriteLine();
            Console.Write("Sides: ");
            int sides = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            MoveImage moveImage = new MoveImage(sides, sides);
            moveImage.MoveImg(type);
        }
    }
}