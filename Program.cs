using spaceshooter;
using spaceshooter.UI;
using System;

public class Program
{
    private const int DisplayHeight = 50;
    private const int DisplayWidth = 100;

    public static Sprite ship = new Ship(50, 25, 'o');
    //public static Sprite ship2 = new Ship(30, 10, 'o');

    public static  void Main(string[] args)
    {
        char[,] displayMatrix = new char[DisplayHeight, DisplayWidth];

        while (true)
        {

            for (int i = 0; i < DisplayHeight; i++)
            {
                for (int j = 0; j < DisplayWidth; j++)
                {
                    displayMatrix[i, j] = '-';
                }
            }

            foreach (Point point in ship.DisplayPoints)
            {
                displayMatrix[point.Y, point.X] = point.DisplayPixel;
            }

            /*foreach (Point point in ship2.DisplayPoints)
            {
                displayMatrix[point.Y, point.X] = point.DisplayPixel;
            }
            */

            for (int i = 0; i < DisplayHeight; i++)
            {
                for (int j = 0; j < DisplayWidth; j++)
                {
                    Console.Write(displayMatrix[i, j]);
                }
                Console.WriteLine();
            }

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                HandleKeyPress(key);
            }

            Console.Clear();
        }
    }

    private static void HandleKeyPress(ConsoleKeyInfo key)
    {

        switch (key.Key)
        {
            case ConsoleKey.LeftArrow:
                ship.moveLeft();
                break;
            case ConsoleKey.RightArrow:
                ship.moveRight();
                break;
            case ConsoleKey.UpArrow:
                ship.moveUp();
                break;
            case ConsoleKey.DownArrow:
                ship.moveDown();
                break;
            case ConsoleKey.Spacebar:
                ship.Fire();
                break;
        }
    }
}