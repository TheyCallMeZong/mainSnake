using System;
using System.Collections.Generic;

namespace mainSnake
{
    class Snake : Figure
    {
        public Direction Direction { get; set; }
        public int Length { get; set; }

        public Snake(Point tail, int length, Direction _direction)
        {
            Direction = _direction;
            Length = length;

            PList = new List<Point>();
            for (int i = 0; i <= Length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, Direction);
                PList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = PList[0];
            PList.RemoveAt(0);
            Point head = GetNextPoint();
            PList.Add(head);
            tail.Clear();
            head.Draw();
        }

        internal bool IsHitTail()
        {
            var head = PList[PList.Count - 1];
            for (int i = 0; i < PList.Count - 2; i++)
            {
                if (head.IsHit(PList[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private Point GetNextPoint()
        {
            Point head = PList[PList.Count - 1];
            Point nextPoint = new Point(head);
            nextPoint.Move(1, Direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.RightArrow)
            {
                if (Direction != Direction.LEFT)
                    Direction = Direction.RIGHT;
            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                if (Direction != Direction.RIGHT)
                    Direction = Direction.LEFT;
            }
            else if (key.Key == ConsoleKey.UpArrow)
            {
                if (Direction != Direction.DOWN)
                    Direction = Direction.UP;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                if (Direction != Direction.UP)
                    Direction = Direction.DOWN;
            }
        }

        public bool Eat(Point food)
        {
            Point head = new Point(PList[PList.Count - 1]);
            if (head.IsHit(food))
            {
                food.Sym = head.Sym;
                PList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
