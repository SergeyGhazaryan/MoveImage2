using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class Rectangle : IShape
    {
        public int height { get; }
        public int width { get; }

        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public void Print(int x, int y)
        {
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(x, y);
                y++;
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}