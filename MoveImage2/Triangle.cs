using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class Triangle
    {
        private int sides;

        public Triangle(int sides)
        {
            this.sides = sides;
        }

        public void Print(int curs1, int curs2)
        {
            for (int i = 0; i < sides; i++)
            {
                Console.SetCursorPosition(curs1, curs2);
                curs2++;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}