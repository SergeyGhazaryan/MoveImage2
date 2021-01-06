using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class RectangleBuilder
    {
        public void CreateRectangle(int type)
        {
            Console.WriteLine("Enter height and width of the rectangle.");
            Console.WriteLine();
            Console.Write("Height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            MoveImage moveImage = new MoveImage(height, width);
            moveImage.MoveImg(type);
        }
    }
}