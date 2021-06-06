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
        ///intializing the board  with empty space


        public const int HEAD = 0;
        public const int TAIL = 1;
        public enum Player { USER, COMPUTER };
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

        public static int GetUserMove(char[] board)
        {
            int[] validCells = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            while (true)
            {
                Console.WriteLine("What is Your next move? (1-9):-");
                int index = Convert.ToInt32(Console.ReadLine());
                if (Array.Find<int>(validCells, elements => elements == index) != 0 && isFreeSpace(board, index))
                    return index;
            }

        }
        static bool isFreeSpace(char[] board, int index)
        {
            return board[index] == ' ';
        }

       //user moving to freespace
        public static void makeMove(char[] board, int index, char letter)
        {
            bool spaceFree = isFreeSpace(board, index);
            if (spaceFree) board[index] = letter;
        }
        public static Player getWhoStartFirst()
        {
            int toss = getOneFromRandomChoice(2);
            return (toss == HEAD) ? Player.USER : Player.COMPUTER;
        }
        public static int getOneFromRandomChoice(int choices)
        {
            Random objRandom = new Random();
            return (int)(objRandom.Next() * 10) % choices;
        }


    }
}
        
       

        
   

    
    
    

