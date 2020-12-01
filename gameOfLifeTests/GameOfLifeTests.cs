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
            Console.WriteLine("Game initiates with an empty grid");
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
            Console.WriteLine("Next step with empty grid contains no changes");
            int[][] expectedGrid = getEmptyGrid();
            Game game = new Game(expectedGrid);
            int[][] gameGrid = game.Step();

            CollectionAssert.AreEqual(expectedGrid[0], gameGrid[0]);
            CollectionAssert.AreEqual(expectedGrid[1], gameGrid[1]);
            CollectionAssert.AreEqual(expectedGrid[2], gameGrid[2]);
            CollectionAssert.AreEqual(expectedGrid[3], gameGrid[3]);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Console.WriteLine("A live cell with no neighbours will die");
            int[][] expectedGrid = getEmptyGrid();
            int[][] initialGrid = getEmptyGrid();
            initialGrid[1][1] = 1;

            Game game = new Game(initialGrid);
            int[][] actualGrid = game.Step();

            CollectionAssert.AreEqual(expectedGrid[0], actualGrid[0]);
            CollectionAssert.AreEqual(expectedGrid[1], actualGrid[1]);
            CollectionAssert.AreEqual(expectedGrid[2], actualGrid[2]);
            CollectionAssert.AreEqual(expectedGrid[3], actualGrid[3]);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Console.WriteLine("A live cell with 1 neighbour will die");
            int[][] expectedGrid = getEmptyGrid();
            int[][] initialGrid = getEmptyGrid();
            initialGrid[1][1] = 1;
            initialGrid[1][2] = 1;

            Game game = new Game(initialGrid);
            int[][] actualGrid = game.Step();

            CollectionAssert.AreEqual(expectedGrid[0], actualGrid[0]);
            CollectionAssert.AreEqual(expectedGrid[1], actualGrid[1]);
            CollectionAssert.AreEqual(expectedGrid[2], actualGrid[2]);
            CollectionAssert.AreEqual(expectedGrid[3], actualGrid[3]);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Console.WriteLine("A live cell with 2 neighbours on the same row will live");
            int[][] expectedGrid = getEmptyGrid();
            expectedGrid[1][1] = 0;
            expectedGrid[1][2] = 1;
            expectedGrid[1][3] = 0;

            int[][] initialGrid = getEmptyGrid();
            initialGrid[1][1] = 1;
            initialGrid[1][2] = 1;
            initialGrid[1][3] = 1;

            Game game = new Game(initialGrid);
            int[][] actualGrid = game.Step();

            CollectionAssert.AreEqual(expectedGrid[0], actualGrid[0]);
            CollectionAssert.AreEqual(expectedGrid[1], actualGrid[1]);
            CollectionAssert.AreEqual(expectedGrid[2], actualGrid[2]);
            CollectionAssert.AreEqual(expectedGrid[3], actualGrid[3]);
        }


        public int[][] getEmptyGrid()
        {
            int[][] emptyGrid = new int[4][];
            emptyGrid[0] = new int[] { 0, 0, 0, 0 };
            emptyGrid[1] = new int[] { 0, 0, 0, 0 };
            emptyGrid[2] = new int[] { 0, 0, 0, 0 };
            emptyGrid[3] = new int[] { 0, 0, 0, 0 };
            return emptyGrid;
        }
    }
}
