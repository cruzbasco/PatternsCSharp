using System;
using System.ComponentModel.DataAnnotations;

namespace Maze.Logic.Iterator
{
    public interface IAbstractIterator
    {
        Square First();
        Square Next();
        bool IsDone { get; }
    }

    public enum IteratorType
    {
        [Display(Name ="Cross Iterator")]
        CrossIterator,
        [Display(Name = "Diagonal Iterator")]
        DiagonalIterator,
        [Display(Name = "Full Iterator")]
        FullIterator
    }

    public class CrossIterator : IAbstractIterator
    {
        private readonly Square[,] _board;
        private readonly int _size;

        private int row;
        private int col;

        private int count;
        private int index;

        public CrossIterator(Square[,] board, int size)
        {
            _board = board;
            _size = size;
            row = 0;
            col = 0;
            count = 0;
        }

        public bool IsDone => count < _size * _size;

        public Square First()
        {
            return _board[row, col];
        }

        public Square Next()
        {
            var random = new Random();
            index = random.Next(6);

            MarkBoard(row, col, _board[row, col].Symbol);
            return NextUncheckedSquare(row, col);
        }

        private Square NextUncheckedSquare(int r, int c)
        {
            if (r == _size)
                return new Square();

            if (_board[r, c].IsChecked)
            {
                c++;
                if (c < _size)
                    return NextUncheckedSquare(r, c);
                else
                    return NextUncheckedSquare(r + 1, 0);
            }
            else
            {
                row = r;
                col = c;
                return _board[r, c];
            }

        }

        public void MarkBoard(int r, int c, char symbol)
        {
            if (IsValid(r) && IsValid(c) && !_board[r, c].IsChecked && _board[r, c].Symbol == symbol)
            {
                _board[r, c].Checked(index);

                count++;

                MarkBoard(r - 1, c, symbol);
                MarkBoard(r + 1, c, symbol);
                MarkBoard(r, c - 1, symbol);
                MarkBoard(r, c + 1, symbol);
            }
        }

        private bool IsValid(int num)
        {
            return num >= 0 && num < _size;
        }
    }

    public class DiagonalIterator : IAbstractIterator
    {
        private readonly Square[,] _board;
        private readonly int _size;

        private int row;
        private int col;

        private int count;
        private int index;

        public DiagonalIterator(Square[,] board, int size)
        {
            _board = board;
            _size = size;
            row = 0;
            col = 0;
            count = 0;
        }

        public bool IsDone => count < _size * _size;

        public Square First()
        {
            return _board[row, col];
        }

        public Square Next()
        {
            var random = new Random();
            index = random.Next(6);

            MarkBoard(row, col, _board[row, col].Symbol);
            return NextUncheckedSquare(row, col);
        }

        private Square NextUncheckedSquare(int r, int c)
        {
            if (r == _size)
                return new Square();

            if (_board[r, c].IsChecked)
            {
                c++;
                if (c < _size)
                    return NextUncheckedSquare(r, c);
                else
                    return NextUncheckedSquare(r + 1, 0);
            }
            else
            {
                row = r;
                col = c;
                return _board[r, c];
            }

        }

        public void MarkBoard(int r, int c, char symbol)
        {
            if (IsValid(r) && IsValid(c) && !_board[r, c].IsChecked && _board[r, c].Symbol == symbol)
            {
                _board[r, c].Checked(index);

                count++;

                MarkBoard(r - 1, c - 1, symbol);
                MarkBoard(r - 1, c + 1, symbol);
                MarkBoard(r + 1, c - 1, symbol);
                MarkBoard(r + 1, c + 1, symbol);
            }
        }

        private bool IsValid(int num)
        {
            return num >= 0 && num < _size;
        }
    }

    public class FullIterator : IAbstractIterator
    {
        private readonly Square[,] _board;
        private readonly int _size;

        private int row;
        private int col;

        private int count;
        private int index;

        public FullIterator(Square[,] board, int size)
        {
            _board = board;
            _size = size;
            row = 0;
            col = 0;
            count = 0;
        }

        public bool IsDone => count < _size * _size;

        public Square First()
        {
            return _board[row, col];
        }

        public Square Next()
        {
            var random = new Random();
            index = random.Next(6);

            MarkBoard(row, col, _board[row, col].Symbol);
            return NextUncheckedSquare(row, col);
        }

        private Square NextUncheckedSquare(int r, int c)
        {
            if (r == _size)
                return new Square();

            if (_board[r, c].IsChecked)
            {
                c++;
                if (c < _size)
                    return NextUncheckedSquare(r, c);
                else
                    return NextUncheckedSquare(r + 1, 0);
            }
            else
            {
                row = r;
                col = c;
                return _board[r, c];
            }

        }

        public void MarkBoard(int r, int c, char symbol)
        {
            if (IsValid(r) && IsValid(c) && !_board[r, c].IsChecked && _board[r, c].Symbol == symbol)
            {
                _board[r, c].Checked(index);

                count++;

                MarkBoard(r - 1, c - 1, symbol);
                MarkBoard(r - 1, c + 1, symbol);
                MarkBoard(r + 1, c - 1, symbol);
                MarkBoard(r + 1, c + 1, symbol);
                MarkBoard(r - 1, c, symbol);
                MarkBoard(r + 1, c, symbol);
                MarkBoard(r, c - 1, symbol);
                MarkBoard(r, c + 1, symbol);
            }
        }

        private bool IsValid(int num)
        {
            return num >= 0 && num < _size;
        }
    }

}
