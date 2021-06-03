using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        public char[] createBoard()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
               Console.WriteLine( board[i] = '_');
            }
            return board;
        }
       
    }
}
