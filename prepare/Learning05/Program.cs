using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executing some task...");
        Console.WriteLine("Please wait...");

        while (true)
        {
            Console.Clear();
            DrawBouncingBalls(10, 5);
            DrawBouncingBalls(20, 5);
            DrawBouncingBalls(30, 5);
            Thread.Sleep(200); // Adjust the sleep duration for speed control
        }
    }

    static void DrawBouncingBalls(int x, int y)
    {
        int direction = 1;
        while (true)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(".");
            Thread.Sleep(200);
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            y += direction;
            if (y == 10 || y == 5)
                direction = -direction;
        }
    }
}

