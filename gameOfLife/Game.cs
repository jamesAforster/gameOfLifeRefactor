using System;

namespace gameOfLife
{
    public class Game
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int[][] Grid()
        {
            int[][] grid = new int[4][];
            grid[0] = new int[] { 0, 0, 0, 0 };
            grid[1] = new int[] { 0, 0, 0, 0 };
            grid[2] = new int[] { 0, 0, 0, 0 };
            grid[3] = new int[] { 0, 0, 0, 0 };
            return grid;
        }
    }
}
