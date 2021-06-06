using System;

namespace TicTacToe
{
   public  class Program
   {
        static void Main(string[] args)
        {
            char[] board = TicTacToeGame.createBoard();                 
            Console.WriteLine(board);
            char choose = TicTacToeGame.chooseUserChar();
            Console.WriteLine("Your choice is " + choose);
            TicTacToeGame.ShowBoard(board);
            int userMove = TicTacToeGame.GetUserMove(board);            
            TicTacToeGame.makeMove(board, userMove, choose);
            TicTacToeGame.getWhoStartFirst();
        }
   }
}
