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
                Console.WriteLine(board[i] = '_');
            }
            return board;
        }
        public static char ChooseUserLetter()
        {
            Console.WriteLine("Enter your choice X or O :");
            string userLetter = Console.ReadLine();
            return char.ToUpper(userLetter[0]);

        }
    }
}
