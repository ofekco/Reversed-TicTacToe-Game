using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLogic
{
    public class GameBoard
    {
        private readonly char[,] r_Matrix;
        private readonly int r_Size;

        public GameBoard(int i_BordSize)
        {
            r_Matrix = new char[i_BordSize, i_BordSize];
            r_Size = i_BordSize;
        }

        public char[,] Board
        {
            get { return r_Matrix; }
        }

        public int Size
        {
            get {return r_Size;}
        }

        public void InitBoard()
        {
            for (int i = 0; i < r_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < r_Matrix.GetLength(1); j++)
                {
                    r_Matrix[i, j] = ' ';
                }
            }
        }

        public GameBoard BoardClone()
        {
            GameBoard clone = new GameBoard(this.r_Size);
            for (int i = 0; i < clone.r_Size; i++)
            {
                for (int j = 0; j < clone.r_Size; j++)
                {
                    clone.r_Matrix[i, j] = this.r_Matrix[i,j];
                }
            }

            return clone;
        }

        public void SetCell(int i_Row, int i_Col, char i_Sign)
        {
            r_Matrix[i_Row, i_Col] = i_Sign;
        }

        public char GetCell(int i_Row, int i_Col)
        {
            return r_Matrix[i_Row, i_Col];
        }

        public bool IsVacentCell(int i_Row, int i_Col)
        {
            return (r_Matrix[i_Row, i_Col] == ' ');
        }

        public bool IsInBoard(int i_Row, int i_Col)
        {
            bool isCellInBoard = true;

            if((i_Row < 0 || i_Row >= r_Size) || (i_Col < 0 || i_Col >= r_Size))
            {
                isCellInBoard = false;
            }

            return isCellInBoard;
        }

        private bool sequenceInRow(char i_PlayerSign)
        {
            int sequenceCounter = 1;
            bool isSomeoneWin = false;

            for (int row = 0; row < r_Matrix.GetLength(0) && (isSomeoneWin == false); row++)
            {
                for (int col = 0; col < r_Matrix.GetLength(1) - 1; col++)
                {
                    if (r_Matrix[row, col] == i_PlayerSign && r_Matrix[row, col + 1] == i_PlayerSign)
                    {
                        sequenceCounter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (sequenceCounter == r_Matrix.GetLength(0))
                {
                    isSomeoneWin = true;
                }

                sequenceCounter = 1;
            }

            return isSomeoneWin;
        }

        private bool sequenceInCol(char i_PlayerSign)
        {
            int sequenceCounter = 1;
            bool isSomeoneWin = false;

            for (int col = 0; col < r_Matrix.GetLength(1) && (isSomeoneWin == false); col++)
            {
                for (int row = 0; row < r_Matrix.GetLength(0) - 1; row++)
                {
                    if (r_Matrix[row, col] == i_PlayerSign && r_Matrix[row + 1, col] == i_PlayerSign)
                    {
                        sequenceCounter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (sequenceCounter == r_Matrix.GetLength(1))
                {
                    isSomeoneWin = true;
                }

                sequenceCounter = 1;
            }

            return isSomeoneWin;
        }

        private bool sequenceInRightDiagonal(char i_PlayerSign)
        {
            int sequenceCounter = 1;
            bool isSomeoneWin = false;

            for (int i = 0; i < r_Matrix.GetLength(0) - 1; i++)
            {
                if (r_Matrix[i, i] == i_PlayerSign && r_Matrix[i + 1, i + 1] == i_PlayerSign)
                {
                    sequenceCounter++;
                }
                else
                {
                    break;
                }
            }

            if (sequenceCounter == r_Matrix.GetLength(0))
            {
                isSomeoneWin = true;
            }

            return isSomeoneWin;
        }

        private bool sequenceInLeftDiagonal(char i_PlayerSign)
        {
            int sequenceCounter = 1, cols = r_Matrix.GetLength(1) - 1;
            bool isSomeoneWin = false;

            for (int rows = 0; rows < r_Matrix.GetLength(0) - 1; rows++)
            {
                if (r_Matrix[rows, cols] == i_PlayerSign && r_Matrix[rows + 1, cols - 1] == i_PlayerSign)
                {
                    sequenceCounter++;
                }
                else
                {
                    break;
                }
                cols--;
            }

            if (sequenceCounter == r_Matrix.GetLength(0))
            {
                isSomeoneWin = true;
            }

            return isSomeoneWin;
        }

        public bool IsSequenceFound(char i_PlayerSign)
        {
            return ((sequenceInCol(i_PlayerSign) || sequenceInRow(i_PlayerSign) || sequenceInRightDiagonal(i_PlayerSign) || sequenceInLeftDiagonal(i_PlayerSign)));
        } 
    }
}
