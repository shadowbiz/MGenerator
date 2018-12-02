using System;

namespace MazeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var maze = new Maze(10, 10);
            maze.Display();

            Console.ReadKey();
        }
    }
}
