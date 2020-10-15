using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuSolver.Strategies;
using SudokuSolver.Workers;

namespace SudokuSolver.Test.Unit.Strategies
{
    [TestClass]
    public class SimpleMarkupStrategyTest
    {
        private readonly ISudokuStrategy _simpleMarkupStrategy = new SimpleMarkUpStrategy(new SudokuMapper());

        [TestMethod]
        public void SimpleStrategyShouldSolveAlmostCompletedSudokuForTopLeftCell()
        {
            int[,] sudokuBoard =
            {
                { 0, 1, 2, 3, 9, 8, 4, 7, 5},
                { 5, 3, 8, 4, 1, 7, 6, 2, 9},
                { 4, 7, 9, 5, 6, 2, 3, 1, 8},
                { 9, 6, 7, 2, 8, 4, 1, 5, 3},
                { 3, 8, 4, 6, 5, 1, 7, 9, 2},
                { 2, 5, 1, 7, 3, 9, 8, 6, 4},
                { 8, 2, 5, 1, 4, 6, 9, 3, 7},
                { 1, 9, 3, 8, 7, 5, 2, 4, 6},
                { 7, 4, 6, 9, 2, 3, 5, 8, 1}
            };

            var solvedSudokuBoard = _simpleMarkupStrategy.Solve(sudokuBoard);

            Assert.IsTrue(solvedSudokuBoard[0, 0] == 6);
        }
    }
}
