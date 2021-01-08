using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class Triangle : IShape
    {
        public int Height { get; }
        public int Width { get; }

        public Triangle(int sides)
        {
            this.Height = this.Width = sides;
        }

        public void Print(int x, int y)
        {
            for (int i = 0; i < Height; i++)
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