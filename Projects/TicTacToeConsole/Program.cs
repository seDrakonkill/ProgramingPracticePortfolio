using System;
using System.Linq;
using System.Security.Permissions;

namespace TicTacToeConsole
{
    internal class Game
    {
        static string[] board = { " ", " ", " ", " ", " ", " ", " ", " ", " " };
        public int roundsPassed = 0;
        static public void Main()
        {
            Console.WriteLine(
                "Welcome to Console-based TicTacToe. The board is numbered 1-9, starting in the upper left corner, going across, then down on each row.\n"
                + "You will be asked where you want to put your letter. Enter the number of an empty space, and the board will fill that spot with your letter\n"
                + "Please decide now who is X and who is O.");
            RunGame();
            Console.ReadKey();

        }
        static int PlayerXorOInputSpot()
        {

            int boardPos = Convert.ToInt32(Console.ReadLine().ToString()); // If the input is incorrect (not a number 9 or less), freezes the whole game.
            boardPos -= 1;
            return boardPos;

        }
        static void RunGame()
        {
            Game game = new Game();
            game.Board();
            for (game.roundsPassed = 0; game.roundsPassed < board.Length; game.roundsPassed++)
            {
                Console.WriteLine("What spot will you put this letter?");
                int index = PlayerXorOInputSpot();

                if (index == Array.IndexOf(board, " ", index)) //My gut says there is a more concise way to do this. If found, retype.
                {
                    string XorO = DetermineXorO(game.roundsPassed);
                    board.SetValue(XorO, index);
                    game.Board();
                }
                else
                { //Make Game retry to put the input in as opposed to just being sassy
                    Console.Clear();
                    Console.WriteLine("Tic Tac Told you to put it in right >:(");
                    Console.ReadKey();
                }
            }
        }
        static string DetermineXorO(int roundsPassed)
        {

            Console.WriteLine(roundsPassed % 2 + " Here " + roundsPassed);
            if (roundsPassed % 2 == 0)
            {
                return "X";
            }
            else
            {
                return "O";
            }
        }
        public void Board()
        {
            Console.WriteLine(
            board[0].ToString() + "|" + board[1].ToString() + "|" + board[2].ToString()
            + "\n_____\n"
            + board[3].ToString() + "|" + board[4].ToString() + "|" + board[5].ToString()
            + "\n_____\n"
            + board[6].ToString() + "|" + board[7].ToString() + "|" + board[8].ToString());
        }

        public static void Restart()
        {

            for (int index = 0; index < board.Length; index++)
            {
                board.SetValue(" ", index);
            }

            RunGame();
        } 

        //Make function to announce winner of game once someone has won. (This might take a while???)


    }
}
