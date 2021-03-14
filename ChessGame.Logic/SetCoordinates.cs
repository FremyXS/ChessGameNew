using System;

namespace ChessGame.Logic
{
    
    public class SetCoordinates
    {
        private static int coordinate_y = 0;
        public static int Coordinate_y { get { return coordinate_y; } }

        private static int coordinate_x = 0;
        public static int Coordinate_x { get { return coordinate_x; } }

        public SetCoordinates(ConsoleKeyInfo key)
        {
            SetCoordinateValue(key);

            SetLimitValue();
        }
        private static void SetCoordinateValue(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.UpArrow)
                coordinate_y--;
            if (key.Key == ConsoleKey.DownArrow)
                coordinate_y++;
            if (key.Key == ConsoleKey.RightArrow)
                coordinate_x++;
            if (key.Key == ConsoleKey.LeftArrow)
                coordinate_x--;
        }
        private static void SetLimitValue()
        {
            if (coordinate_y > 7)
                coordinate_y = 0;
            if (coordinate_y < 0)
                coordinate_y = 7;
            if (coordinate_x > 7)
                coordinate_x = 0;
            if (coordinate_x < 0)
                coordinate_x = 7;
        }
    }
}
