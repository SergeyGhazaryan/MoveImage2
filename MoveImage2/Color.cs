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

        public static void SetConsoleColor(string userColor)
        {
            ConsoleColor consColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), userColor);
            Console.ForegroundColor = consColor;
        }

        public void GetConsoleColor()
        {
            string[] namesColor = Enum.GetNames(typeof(ConsoleColor));
            bool selected = false;
            foreach (string userColor in namesColor)
            {
                if (userColor == foregroundColor)
                {
                    SetConsoleColor(userColor);
                    selected = true;
                }
            }
            if (!selected)
            {
                Console.WriteLine("You can not do that...You have the following options: Black, Blue, " +
                "Cyan, Gray, Green, Magenta, Red, White, YellowDarkBlue, DarkCyan, DarkGray, " +
                "DarkGreen, DarkMagenta, DarkRed, DarkYellow");
            }
        }
    }
}