using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int playFieldWidth = 140;
            int playFieldHeight = 40;

            int playerPositionX = 5;
            int playerPositionY = 5;

            // Initalisierung des Fensters
            Console.WindowWidth = playFieldWidth + 2;
            Console.WindowHeight = playFieldHeight + 2;
            Console.BufferWidth = playFieldWidth + 2;
            Console.BufferHeight = playFieldHeight + 2;
            Console.CursorVisible = false;

            // Initialisierung des Spielfeldes
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.Gray;
            for (int x = 0; x < playFieldWidth; x++)
            {
                for (int y = 0; y < playFieldHeight; y++)
                {
                    Console.SetCursorPosition(x + 1, y + 1);
                    Console.Write(" ");
                }
            }

            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(playerPositionX, playerPositionY);
            Console.Write(" ");

            


            Console.ReadLine();
        }
    }
}
