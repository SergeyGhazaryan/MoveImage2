using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class Rectangle
    {
        private int height;
        private int width;

        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public void Print(int curs1, int curs2)
        {
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(curs1, curs2);
                curs2++;
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}