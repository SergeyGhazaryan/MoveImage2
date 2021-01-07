using System;
using System.Collections.Generic;
using System.Text;
using Form;

namespace Form
{
    class MoveImage
    {
        private IShape shape;

        public MoveImage(IShape shape)
        {
            this.shape = shape;
        }

        public object MoveImg()
        {
            int x = 0, y = 0;
            while (true)
            {
                Console.Clear();
                shape.Print(x, y);
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (x > 0)
                        {
                            x--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (x < Console.WindowWidth - shape.width)
                        {
                            x++;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (y < Console.WindowHeight - shape.width)
                        {
                            y++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (y > 0)
                        {
                            y--;
                        }
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}