using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class RectangleBuilder : IFigureBuilder
    {
        public void Create()
        {
            bool notNumber = true;
            while (notNumber)
            {
                Console.WriteLine("Enter height and width of the rectangle.");
                Console.WriteLine();
                Console.Write("Height: ");
                string h = Console.ReadLine();
                bool number1 = int.TryParse(h, out int height);
                Console.Write("Width: ");
                string w = Console.ReadLine();
                bool number2 = int.TryParse(w, out int width);
                if (number1 && number2)
                {
                    Console.WriteLine();
                    IShape shape = new Rectangle(height, width);
                    MoveImage moveImage = new MoveImage(shape);
                    moveImage.MoveImg();
                    notNumber = false;
                }
                else 
                {
                    Console.WriteLine("You must enter a number.");
                }
            }
        }
    }
}