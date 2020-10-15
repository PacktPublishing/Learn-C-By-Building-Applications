using SudokuSolver.Strategies;
using SudokuSolver.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Strategies
{
    class SudokuSolverEngine
    {
        private readonly SudokuBoardStateManager _sudokuBoardStateManager;
        private readonly SudokuMapper _sudokuMapper;

        public SudokuSolverEngine(SudokuBoardStateManager sudokuBoardStateManager, SudokuMapper sudokuMapper)
        {
            _sudokuBoardStateManager = sudokuBoardStateManager;
            _sudokuMapper = sudokuMapper;
        }

        public bool Solve(int[,] sudokuBoard)
        {
            List<ISudokuStrategy> strategies = new List<ISudokuStrategy>()
            {
                new SimpleMarkUpStrategy(_sudokuMapper),
                new NakedPairsStrategy(_sudokuMapper)
            };

            var currentState = _sudokuBoardStateManager.GenerateState(sudokuBoard);
            var nextState = _sudokuBoardStateManager.GenerateState(strategies.First().Solve(sudokuBoard));

            while(!_sudokuBoardStateManager.IsSolved(sudokuBoard) && currentState != nextState)
            {
                currentState = nextState;
                foreach (var strategy in strategies) nextState = _sudokuBoardStateManager.GenerateState(strategy.Solve(sudokuBoard));
            }
            
            return _sudokuBoardStateManager.IsSolved(sudokuBoard);
        }
    }
}
