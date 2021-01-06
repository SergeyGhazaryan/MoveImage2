using System;
using System.Collections.Generic;
using System.Text;
using Form;

namespace Form
{
    class MoveImage
    {
        private int height;
        private int width;

        public MoveImage(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public void MoveImg(int type)
        {
            int curs1 = 0, curs2 = 0;
            while (true)
            {
                Print(type, curs1, curs2);
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (curs1 > 0)
                        {
                            curs1--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (curs1 < Console.WindowWidth - width)
                        {
                            curs1++;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (curs2 < Console.WindowHeight - height)
                        {
                            curs2++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (curs2 > 0)
                        {
                            curs2--;
                        }
                        break;
                }
            }
        }

        public void Print(int type, int curs1, int curs2)
        {
            Console.Clear();
            if (type == 1)
            {
                Rectangle rectangle = new Rectangle(height, width);
                rectangle.Print(curs1, curs2);
            }
            else if (type == 2)
            {
                Triangle triangle = new Triangle(height);
                triangle.Print(curs1, curs2);
            }
        }
    }
}