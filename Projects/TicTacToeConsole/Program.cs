using System;
using System.Linq;

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
                int index = PlayerXorOInputSpot();
                if (board.Contains<string>(" ")) //this doesnt specify a specific index spot, does it? No, it doesnt. Does this mean I can remove the For loop and just have the computer keep running this on repeat until the game board is out of ""s?
                {
                    string XorO = DetermineXorO(game.roundsPassed);
                    board.SetValue(XorO, index);
                    game.Board();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Tic Tac Told you to put it in right >:(");
                    Console.ReadKey();
                }
            }
        }
        static string DetermineXorO(int roundsPassed)
        {
            
            Console.WriteLine(roundsPassed % 2 + " Here " + roundsPassed);
            if (roundsPassed%2 == 0/*remainder or round/2 = 0,*/ )
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

        /*static string PlayerXInput()
{
    Console.WriteLine("Player 1 (X), Please put in your input now");
    string playerInput = Console.ReadLine().ToString();
    switch (playerInput)
    {
        case "X":
            return playerInput;
        case "x":
            return playerInput;

        default:
            Console.WriteLine("That is not an X.");
            return playerInput;
    }
}

static string PlayerOInput()
{
    Console.WriteLine("Player 2 (O), Please put in your input now");
    string playerInput = Console.ReadLine().ToString();
    switch (playerInput)
    {
        case "O":
            return playerInput;
        case "o":
            return playerInput;

        default:
            Console.WriteLine("That is not an O.");
            return playerInput;
    }
}*/
    }
}
