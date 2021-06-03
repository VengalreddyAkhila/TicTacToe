using System;

namespace TicTacToe
{
   public  class Program
   {
        static void Main(string[] args)
        {
            TicTacToeGame TicTac = new TicTacToeGame();        
            TicTac.createBoard();
            char choose = TicTacToeGame.chooseUserLetter();
            Console.WriteLine("Your choice is " + choose);
        }
   }
}
