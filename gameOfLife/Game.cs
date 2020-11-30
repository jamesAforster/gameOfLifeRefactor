using System;

namespace gameOfLife
{
    public class Game
    { 
    public int[][] grid;

        public Game(int[][] inputGrid)
        {
            grid = inputGrid;
        }

        public int[][] Step()
        {
            grid[1][1] = 0;
            return grid;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
