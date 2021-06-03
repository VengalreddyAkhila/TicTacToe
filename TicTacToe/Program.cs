using System;

namespace TicTacToe
{
   public  class Program
   {
        static void Main(string[] args)
        {
            char[] board = TicTacToeGame.createBoard();                 //calling an method by usung class name
            Console.WriteLine(board);
            char choose = TicTacToeGame.chooseUserChar();
            Console.WriteLine("Your choice is " + choose);            
            TicTacToeGame.ShowBoard(board);

            Console.ReadKey();
            /*TicTacToeGame TicTac = new TicTacToeGame();
            TicTac.createBoard();
            char choose = TicTacToeGame.ChooseUserLetter();
            Console.WriteLine("Your choice is " + choose);
            TicTac.ShowBoard(board);
            Console.ReadLine();*/
        }
   }
}
