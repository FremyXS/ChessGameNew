using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Logic
{
    public class MoveOfFigure
    {
        public static int start_x { get; private set; }
        public static int start_y { get; private set; }
        public static int end_x { get; private set; }
        public static int end_y { get; private set; }

        private static int switcher = 0;

        public MoveOfFigure()
        {
            SetPositions();
        }
        private static void SetPositions()
        {
            if(switcher == 0)
            {
                start_x = SetCoordinates.Coordinate_x;
                start_y = SetCoordinates.Coordinate_y;

                switcher++;
            }
            else
            {
                end_x = SetCoordinates.Coordinate_x;
                end_y = SetCoordinates.Coordinate_y;

                switcher = 0;

                Moving();
            }
        }
        private static void Moving()
        {
            if(SetLocationFigures.arrayBoard[start_y, start_x]!= null)
            {
                if (SetLocationFigures.arrayBoard[end_y, end_x] == null)
                {
                    if (CorrectMove.Move())
                    {
                        SetLocationFigures.arrayBoard[end_y, end_x] = SetLocationFigures.arrayBoard[start_y, start_x];

                        SetLocationFigures.arrayBoard[start_y, start_x] = null;
                    }
                }

            }
        }
    }
}
