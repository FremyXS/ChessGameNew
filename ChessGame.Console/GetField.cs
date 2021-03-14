using System;
using System.Collections.Generic;
using System.Text;
using ChessGame.Logic;

namespace ChessGame.Console
{
    public class GetField
    {
        public GetField()
        {
            System.Console.ForegroundColor = ConsoleColor.Magenta;

            Drawing();
        }
        private static void Drawing()
        {
            for(int i = 0; i < 8; i++)
            {
                if (i == 0)
                    OneString('┌', '┬', '┐', '─', -1);

                OneString('│', '│', '│', ' ', i);

                if (i == 7)
                    OneString('└', '┴', '┘', '─', -1);
                else
                    OneString('├', '┼', '┤', '─', -1);
            }
        }
        private static void OneString(char x1, char x2, char x3, char x4, int i)
        {
            for(int j = 0; j < 8; j++)
            {
                if(j == 0)
                    System.Console.Write(x1);

                SetColorForCell(i, j);

                GetCell(i, j, x4);

                SetResetColor();

                if(j == 7)
                    System.Console.WriteLine(x3);
                else
                    System.Console.Write(x2);
            }
        }
        private static void GetCell(int i, int j, char x4)
        {
            if( i > -1)
            {
                if(SetLocationFigures.arrayBoard[i, j]!= null)
                {
                    System.Console.Write(x4);
                    System.Console.Write(SetLocationFigures.arrayBoard[i, j]);
                    System.Console.Write(x4);
                }
                else
                    System.Console.Write(new string(x4, 3));

            }
            else
            {
                System.Console.Write(new string(x4, 3));
            }
        }
        private static void SetColorForCell(int i, int j)
        {
            if(i == SetCoordinates.Coordinate_y && j == SetCoordinates.Coordinate_x)
            {
                System.Console.BackgroundColor = ConsoleColor.White;
            }
            
        }
        private static void SetResetColor()
        {
            System.Console.BackgroundColor = ConsoleColor.Black;
        }
    }
    
}
