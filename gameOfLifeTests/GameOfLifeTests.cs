using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gameOfLife;

namespace gameOfLifeTests
{
    [TestClass]
    public class GameOfLifeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Game initiates with an empty grid: ");
            int [][] expectedGrid = getEmptyGrid();
            Game game = new Game(expectedGrid);

            CollectionAssert.AreEqual(expectedGrid[0], game.grid[0]);
            CollectionAssert.AreEqual(expectedGrid[1], game.grid[1]);
            CollectionAssert.AreEqual(expectedGrid[2], game.grid[2]);
            CollectionAssert.AreEqual(expectedGrid[3], game.grid[3]);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("Next step with empty grid contains no changes: ");
            int[][] expectedGrid = getEmptyGrid();
            Game game = new Game(expectedGrid);
            int[][] gameGrid = game.Step();

            CollectionAssert.AreEqual(expectedGrid[0], gameGrid[0]);
            CollectionAssert.AreEqual(expectedGrid[1], gameGrid[1]);
            CollectionAssert.AreEqual(expectedGrid[2], gameGrid[2]);
            CollectionAssert.AreEqual(expectedGrid[3], gameGrid[3]);
        }

    public int[][] getEmptyGrid()
        {
            int[][] expectedGrid = new int[4][];
            expectedGrid[0] = new int[] { 0, 0, 0, 0 };
            expectedGrid[1] = new int[] { 0, 0, 0, 0 };
            expectedGrid[2] = new int[] { 0, 0, 0, 0 };
            expectedGrid[3] = new int[] { 0, 0, 0, 0 };
            return expectedGrid;
        }
    }
}
