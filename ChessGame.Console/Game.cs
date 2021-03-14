using System;
using System.Collections.Generic;
using System.Text;
using ChessGame.Logic;

namespace ChessGame.Console
{
    public class Game
    {
        public Game()
        {
            SetLocationFigures.IntialLocation();

            ConsoleKeyInfo key;

            do 
            {
                new GetField();

                key = System.Console.ReadKey();

                SetBuuton(key);

                System.Console.Clear();

            } while (key.Key != ConsoleKey.Escape);
        }
        private static void SetBuuton(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.Enter)
            {
                new MoveOfFigure();
            }
            else
            {
                new SetCoordinates(key);
            }
        }
    }
}
