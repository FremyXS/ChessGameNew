using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Logic
{
    public class CorrectMove
    {
        private static int differenceHorizontal;
        private static int differenceDiagonal;

        public static bool Move()
        {
            differenceHorizontal = Math.Abs(MoveOfFigure.start_x - MoveOfFigure.end_x);
            differenceDiagonal = Math.Abs(MoveOfFigure.start_y - MoveOfFigure.end_y);

            bool b00l = false;

            switch (SetLocationFigures.arrayBoard[MoveOfFigure.start_y, MoveOfFigure.start_x])
            {
                case "K":
                    b00l = MoveKing();
                    break;
                case "Q":
                    b00l = MoveQueen();
                    break;
                case "B":
                    b00l = MoveBishop();
                    break;
                case "H":
                    b00l = MoveHorse();
                    break;
                case "R":
                    b00l = MoveRook();
                    break;
                case "P":
                    b00l = MovePawn();
                    break;
                default:
                    break;
            }

            return b00l;
        }
        private static bool MoveKing()
        {
            if (differenceHorizontal == 1 && differenceDiagonal == 1 || differenceHorizontal == 1 && differenceDiagonal == 0 || differenceHorizontal == 0 && differenceDiagonal == 1)
            {
                return true;
            }
            return false;
        }
        private static bool MoveQueen()
        {
            if (differenceDiagonal == differenceHorizontal || differenceDiagonal == 0 && differenceHorizontal > 0 || differenceDiagonal > 0 && differenceHorizontal == 0)
            {
                return true;
            }

            return false;
        }
        private static bool MoveBishop()
        {
            if(differenceDiagonal == differenceHorizontal)
            {
                return true;
            }

            return false;
        }
        private static bool MoveHorse()
        {
            if(differenceHorizontal == 1 && differenceDiagonal == 2 || differenceHorizontal == 2 && differenceDiagonal == 1)
            {
                return true;
            }
            return false;
        }
        private static bool MoveRook()
        {
            if(differenceHorizontal == 0 && differenceDiagonal > 0 || differenceHorizontal > 0 && differenceDiagonal == 0)
            {
                return true;
            }

            return false;
        }
       
        private static bool MovePawn()
        {
            if(MoveOfFigure.start_y == 6)
            {
                if(differenceHorizontal == 0 && differenceDiagonal == 1 || differenceHorizontal == 0 && differenceDiagonal == 2)
                {
                    return true;
                }

                return false;
            }
            else if (MoveOfFigure.start_y < 6)
            {
                if(differenceHorizontal == 0 && differenceDiagonal == 1)
                {
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}
