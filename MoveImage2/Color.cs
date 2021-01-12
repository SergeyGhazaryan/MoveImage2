using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public void SelectConsoleColor()
        {
            string[] namesColor = Enum.GetNames(typeof(ConsoleColor));

            var linqQueryForColor = from userColor in namesColor
                       where userColor.Equals(foregroundColor)
                       select userColor;

            if (linqQueryForColor.Count() == 0)
            {
                Console.WriteLine("You can not do that...You have the following options: Black, Blue, " +
                "Cyan, Gray, Green, Magenta, Red, White, YellowDarkBlue, DarkCyan, DarkGray, " +
                "DarkGreen, DarkMagenta, DarkRed, DarkYellow");
            }
            else
            {
                SetConsoleColor(linqQueryForColor.Single());
            }
        }
    }
}