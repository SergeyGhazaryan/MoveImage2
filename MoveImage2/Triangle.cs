using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class Triangle : IShape
    {
        private int height;
        private int width;


        public Triangle(int sides)
        {
            this.height = this.width = sides;
        }

        public int GetHeight()
        {
            return this.height;
        }

        public int GetWidth()
        {
            return this.width;
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