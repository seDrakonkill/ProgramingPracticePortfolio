using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeConsole
{
    internal class TicTacToeInConsole
    {
        string[] board = { "0,0", "1,0", "2,0", "0,1", "0,2", "1,1", "1,2", "2,1", "2,2", };
        static void Main()
        {

        }

        static string PlayerXInput()
        {
            string playerInput = Console.ReadLine().ToString();
            return playerInput;
        }

        static string PlayerOInput()
        {
            string playerInput = Console.ReadLine().ToString();
            if (playerInput == "o" || playerInput == "O")
            {
                return playerInput;
            }
            else
            {
                Console.WriteLine("That is not the correct character. Please Enter O");
                

            }

        }
    }
}
