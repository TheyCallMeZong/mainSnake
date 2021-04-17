using System;
using System.Threading;

namespace mainSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 40);
            Console.WindowHeight = 40;
            Console.WindowWidth = 120;
            Console.CursorVisible = false;

            Walls walls = new(119, 39);
            walls.Draw();

            Point p1 = new(10, 10, '*');
            Snake snake = new(p1, 7, Direction.RIGHT);
            snake.Draw();
            snake.Move();


            FoodCreator foodCreator = new(118, 38, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();



            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.Clear();
                    Console.SetCursorPosition(60, 20);
                    Console.WriteLine("GAME OVER");
                    Console.ReadKey();
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    Thread.Sleep(50);
                }
                else
                {
                    snake.Move();
                }


                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key);
                }
                Thread.Sleep(50);

            }
        }
    }
}
