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
            return grid;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
