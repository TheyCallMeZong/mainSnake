using System;

namespace mainSnake
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Sym { get; set; }

        public Point(int x, int y, char sym)
        {
            X = x;
            Y = y;
            Sym = sym;
        }

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            Sym = p.Sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Sym);
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.LEFT)
            {
                X -= offset;
            }
            else if (direction == Direction.RIGHT)
            {
                X += offset;
            }
            else if (direction == Direction.UP)
            {
                Y -= offset;
            }
            else if (direction == Direction.DOWN)
            {
                Y += offset;
            }
        }

        public void Clear()
        {
            Sym = ' ';
            Draw();
        }

        public bool IsHit(Point p)
        {
            return p.X == X && p.Y == Y;
        }
    }
}
