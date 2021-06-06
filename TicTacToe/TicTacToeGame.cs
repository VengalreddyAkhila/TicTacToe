using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    static class TicTacToeGame
    {
        /// <summary>
        /// TicTacToe game plays in a gameboard 
        /// </summary>
        /// <returns></returns>
        //intializing the board  with empty space
        public static char[] createBoard()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                Console.WriteLine(board[i] = '_');
            }
            return board;
        }
        //user choosing the option 
        public static char chooseUserChar()
        {
            Console.WriteLine("Enter your choice X or O :");
            char userSelection = Convert.ToChar(Console.ReadLine());
            return char.ToUpper(userSelection);

        }
        //displaying the gameboard
        public static void ShowBoard(char[] board)
        {
            Console.WriteLine("  1  |  2  |  3 ");
            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("  4  |  5  |  6");
            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("  7  |  8  |  9");
            Console.WriteLine("     |     |      ");
        }
        //user makeing a move in gameboard

        public static char[] UserMove(char[] board)
        {
            Console.WriteLine("select the location on Board :  ");
            int location = Convert.ToInt32(Console.ReadLine());            
            while (location > 9 || location < 1)
            {
                Console.WriteLine("invalid location, select the location on Board :  ");                
            }
            location = CheckBoard(location, board);
            if (location == 0)
            { 
                Console.WriteLine("location already selected");
                Console.WriteLine("select another location on Board :  ");
                
            }
            else
            {
                board[location] = 'x';
            }
            return board;
        }       

        private static int CheckBoard(int location, char[] board)
            {
                if (board[location] != ' ')
                {
                    return 0;
                }
                else
                {
                    return location;
                }
            }
        
    }
}
    
    
    

