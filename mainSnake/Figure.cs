using System.Collections.Generic;

namespace mainSnake
{
    class Figure
    {
        public List<Point> PList { get; set; }

        public virtual void Draw()
        {
            foreach (Point p in PList)
            {
                p.Draw();
            }
        }

        public bool IsHit(Figure figure)
        {
            foreach (var p in PList)
            {
                if (figure.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsHit(Point point)
        {
            foreach (var p in PList)
            {
                if (point.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
