using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuSolver.Strategies;
using SudokuSolver.Workers;

namespace SudokuSolver.Test.Unit.Strategies
{
    [TestClass]
    public class NakedPairsStrategyTest
    {
        private readonly ISudokuStrategy _nakedPairsStrategy = new NakedPairsStrategy(new SudokuMapper());

        [TestMethod]
        public void ShouldEliminateNumbersInRowBasedOnNakedPair()
        {
            int[,] sudokuBoard =
            {
                { 1, 2, 34, 5 , 34, 6, 7, 348, 9},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
            };

            var solvedSudokuBoard = _nakedPairsStrategy.Solve(sudokuBoard);

            Assert.IsTrue(solvedSudokuBoard[0, 7] == 8);
        }

        [TestMethod]
        public void ShouldEliminateNumbersInColBasedOnNakedPair()
        {
            int[,] sudokuBoard =
            {
                { 1, 0, 0, 0 , 0, 0, 0, 0, 0},
                { 24, 0, 0, 0, 0, 0, 0, 0, 0},
                { 3, 0, 0, 0, 0, 0, 0, 0, 0},
                { 5, 0, 0, 0, 0, 0, 0, 0, 0},
                { 6, 0, 0, 0, 0, 0, 0, 0, 0},
                { 24, 0, 0, 0, 0, 0, 0, 0, 0},
                { 7, 0, 0, 0, 0, 0, 0, 0, 0},
                { 8, 0, 0, 0, 0, 0, 0, 0, 0},
                { 249, 0, 0, 0, 0, 0, 0, 0, 0},
            };

            var solvedSudokuBoard = _nakedPairsStrategy.Solve(sudokuBoard);

            Assert.IsTrue(solvedSudokuBoard[8, 0] == 9);
        }

        [TestMethod]
        public void ShouldEliminateNumbersInBlock1BasedOnNakedPair()
        {
            int[,] sudokuBoard =
            {
                { 1, 2, 3, 0 , 0, 0, 0, 0, 0},
                { 45, 6, 7, 0, 0, 0, 0, 0, 0},
                { 8, 45, 459, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
            };

            var solvedSudokuBoard = _nakedPairsStrategy.Solve(sudokuBoard);

            Assert.IsTrue(solvedSudokuBoard[2, 2] == 9);
        }

        [TestMethod]
        public void ShouldEliminateNumbersInBlock5BasedOnNakedPair()
        {
            int[,] sudokuBoard =
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 7, 8, 9, 0, 0, 0},
                { 0, 0, 0, 12, 3, 4, 0, 0, 0},
                { 0, 0, 0, 6, 12, 125, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
            };

            var solvedSudokuBoard = _nakedPairsStrategy.Solve(sudokuBoard);

            Assert.IsTrue(solvedSudokuBoard[5, 5] == 5);
        }

        [TestMethod]
        public void ShouldEliminateNumbersInBlock9BasedOnNakedPair()
        {
            int[,] sudokuBoard =
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0 ,0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 0, 0, 0, 0, 1, 2, 3},
                { 0, 0, 0, 0, 0, 0, 4, 56, 56},
                { 0, 0, 0, 0, 0, 0, 567, 8, 9},
            };

            var solvedSudokuBoard = _nakedPairsStrategy.Solve(sudokuBoard);

            Assert.IsTrue(solvedSudokuBoard[8, 6] == 7);
        }
    }
}
