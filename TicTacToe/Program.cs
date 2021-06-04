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
            TicTacToeGame.UserMove(board);
            board = TicTacToeGame.UserMove(board);
            TicTacToeGame .ShowBoard(board);

        }
   }
}
