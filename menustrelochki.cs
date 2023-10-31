using CookieCakesFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieCakesFiles
{
    internal class ArrowsMenu
    {
        public static int Show(int pos, int minStrelochka, int maxStrelochka)
        {
   
            ConsoleKeyInfo key;

            do
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, pos);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("->");
                Console.ResetColor();
                key = Console.ReadKey();

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && pos != minStrelochka)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow && pos != maxStrelochka)
                {
                    pos++;
                }

                if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    return -1;
                }

            } while (key.Key != ConsoleKey.Enter);

            Console.Clear();
            return pos;

        }
    }
}