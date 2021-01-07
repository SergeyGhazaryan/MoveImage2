using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class Color
    {
        private string foregroundColor;

        public Color(string foregrcolor)
        {
            this.foregroundColor = foregrcolor;
        }

        public void GetConsoleColor()
        {
            string[] names = Enum.GetNames(typeof(ConsoleColor));

            bool num = false;
            foreach (string color in names)
            {
                if (color == foregroundColor)
                {
                    ConsoleColor consCol = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
                    Console.ForegroundColor = consCol;
                    num = true;
                }
            }
            if (num == false)
            {
                Console.WriteLine("You can not do that...You have the following options: Black, Blue, " +
                "Cyan, Gray, Green, Magenta, Red, White, YellowDarkBlue, DarkCyan, DarkGray, " +
                "DarkGreen, DarkMagenta, DarkRed, DarkYellow");
            }
        }
    }
}