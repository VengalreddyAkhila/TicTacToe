using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    static class TicTacToeGame
    {
        //intialize board 
        public static char[] createBoard()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                Console.WriteLine(board[i] = '_');
            }
            return board;
        }
        //choose letter
        public static char chooseUserChar()
        {
            Console.WriteLine("Enter your choice X or O :");
            char userSelection = Convert.ToChar(Console.ReadLine());
            return char.ToUpper(userSelection);

        }
        //displayboard
        public static void ShowBoard(char[] board)
        {            
            Console.WriteLine("  1  |  2  |  3 "); 
            Console.WriteLine("_____|_____|_____ ");          

            Console.WriteLine("  4  |  5  |  6"); 
            Console.WriteLine("_____|_____|_____ ");                 

            Console.WriteLine("  7  |  8  |  9");
            Console.WriteLine("     |     |      ");
        }
        public static int UserMove(char[] board)
        {
            int[] validCells = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            while (true)
            {
                Console.WriteLine("What is Your next move(1-9)???");
                int index = Convert.ToInt32(Console.ReadLine());
                if (Array.Find<int>(validCells, elements => elements == index) != 0 && isFreeSpace(board, index))
                 return index;
            }
        }
        public static bool isFreeSpace(char[] board, int index)
        {
            return board[index] == ' ';
        }

    }
    
}
