using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class ColorForConsole
    {
        private string foregroundColor;

        public ColorForConsole(string foregrcolor)
        {
            this.foregroundColor = foregrcolor;
        }

        public static void SetConsoleColor(string color)
        {
            ConsoleColor consColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
            Console.ForegroundColor = consColor;
        }

        public void GetConsoleColor()
        {
            string[] names = Enum.GetNames(typeof(ConsoleColor));

            bool selected = false;
            foreach (string color in names)
            {
                if (color == foregroundColor)
                {
                    SetConsoleColor(color);
                    selected = true;
                }
            }
            if (selected == false)
            {
                Console.WriteLine("You can not do that...You have the following options: Black, Blue, " +
                "Cyan, Gray, Green, Magenta, Red, White, YellowDarkBlue, DarkCyan, DarkGray, " +
                "DarkGreen, DarkMagenta, DarkRed, DarkYellow");
            }
        }
    }
}