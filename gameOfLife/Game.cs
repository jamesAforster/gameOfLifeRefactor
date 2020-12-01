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

        public int[][] newGrid()
        {
            int[][] emptyGrid = new int[4][];
            emptyGrid[0] = new int[] { 0, 0, 0, 0 };
            emptyGrid[1] = new int[] { 0, 0, 0, 0 };
            emptyGrid[2] = new int[] { 0, 0, 0, 0 };
            emptyGrid[3] = new int[] { 0, 0, 0, 0 };
            return emptyGrid;
        }

        public int[][] Step()
        {
            int[][] returnGrid = newGrid();
            int rowIndex = 0;
            foreach (int[] row in grid)
            {
                int elementIndex = 0;
                foreach (int i in row)
                {
                    int count = 0;

                    try
                    {
                        if (row[elementIndex - 1] == 1)
                        {
                            count += 1;
                        }
                        if (row[elementIndex + 1] == 1)
                        {
                            count += 1;
                        }
                        Console.WriteLine(count);
                    }
                    catch(IndexOutOfRangeException)
                    {
                        Console.Write("Out of range");
                    }

                    if (count < 2)
                    {
                        returnGrid[rowIndex][elementIndex] = 0;
                    }
                    if (count == 2)
                    {
                        returnGrid[rowIndex][elementIndex] = 1;
                    }
                    elementIndex++;
                }
                rowIndex++;
            }
            foreach (int[] row in returnGrid)
            {
                foreach (int i in row)
                {
                    Console.WriteLine(i);
                }
            }

            return returnGrid;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
