using System.Collections.Generic;

namespace mainSnake
{
    class Walls
    {
        public List<Figure> ListWalls;
        public Walls(int Width, int Hight)
        {
            HorizontalLine hline1 = new HorizontalLine(0, 0, Width, '#');
            HorizontalLine hline2 = new HorizontalLine(0, Hight, Width, '#');
            VerticalLine vline1 = new VerticalLine(0, 0, Hight, '#');
            VerticalLine vline2 = new VerticalLine(Width, 0, Hight, '#');

            ListWalls = new List<Figure>();

            ListWalls.Add(hline1);
            ListWalls.Add(hline2);
            ListWalls.Add(vline1);
            ListWalls.Add(vline2);
        }

        public void Draw()
        {
            foreach (Figure f in ListWalls)
            {
                f.Draw();
            }
        }

        internal bool IsHit(Figure snake)
        {
            foreach (var wall in ListWalls)
            {
                if (wall.IsHit(snake))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
