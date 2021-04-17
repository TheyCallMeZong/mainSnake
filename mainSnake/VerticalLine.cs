using System.Collections.Generic;

namespace mainSnake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int start_x, int start_y, int finish_y, char symbol)
        {
            PList = new List<Point>();
            for (int i = start_y; i <= finish_y; i++)
            {
                PList.Add(new Point(start_x, i, symbol));
            }
        }
    }
}
