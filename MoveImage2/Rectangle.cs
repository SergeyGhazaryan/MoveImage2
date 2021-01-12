using System;

namespace Form
{
    class Rectangle : IShape
    {
        public int Height { get; }
        public int Width { get; }

        public Rectangle(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public void Print(int x, int y)
        {
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(x, y);
                y++;
                for (int j = 0; j < Width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}