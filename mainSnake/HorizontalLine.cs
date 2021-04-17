using System.Collections.Generic;

namespace mainSnake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int start_x, int start_y, int finish_x, char symbol)
        {
            PList = new List<Point>();
            for (int i = start_x; i <= finish_x; i++)
            {
                PList.Add(new Point(i, start_y, symbol));
            }
        }
    }
}
