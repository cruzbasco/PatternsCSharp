using System;
using System.Collections.Generic;
using System.IO;

namespace Maze.Logic.Iterator
{
    public class BoardAggregate : IAggregate
    {
        private readonly int _size;
        private readonly Square[,] _board;

        public int Size { get { return _size; } init { } }

        public BoardAggregate(int size = 10)
        {
            _board = new Square[size, size];
            _size = size;

            for (int r = 0; r < _size; r++)
            {
                for (int c = 0; c < _size; c++)
                {
                    _board[r, c] = new Square();
                }
            }
        }

        public Square GetSquare(int row, int col)
        {
            return _board[row, col];
        }

        public void Load(string board = "Board1")
        {
            // windows path
            //   string directory = @"D:\code\bridgeDemo\Maze.Web";
            //   string[] lines = File.ReadAllLines(@$"{directory}\Boards\{board}.txt");

            //   mac path 
            string[] lines = File.ReadAllLines(@$"/Users/cruzbasco/projects/PatternsCSharp/Maze.Web/Boards/Board1.txt");

            for (int r = 0; r < _size; r++)
            {
                for (int c = 0; c < _size; c++)
                {
                    _board[r, c].Symbol = lines[r][c];
                }
            }
        }

        public IEnumerable<string> Print()
        {
            for (int r = 0; r < _size; r++)
            {
                var result = "";
                for (int c = 0; c < _size; c++)
                {
                    //result += _board[r, c].Symbol + " " + _board[r, c].IsChecked.ToString() + " ";
                    result += _board[r, c].Symbol;
                }

                yield return result;
            }
        }

        public void ToLower()
        {
            for (int row = 0; row < _size; row++)
            {
                for (int col = 0; col < _size; col++)
                {
                    _board[row, col].ToLower();
                }
            }
        }

        public IAbstractIterator CreateIterator(IteratorType iteratorType)
        {
            return iteratorType switch
            {
                IteratorType.CrossIterator => new CrossIterator(_board, _size),
                IteratorType.DiagonalIterator => new DiagonalIterator(_board, _size),
                _ => new FullIterator(_board, _size)
            };
        }
    }
}
