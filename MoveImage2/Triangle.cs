using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class Triangle : IShape
    {
        public int height { get; }
        public int width { get; }

        public Triangle(int sides)
        {
            this.height = this.width = sides;
        }

        public void Print(int x, int y)
        {
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(x, y);
                y++;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}