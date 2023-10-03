using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;

namespace BabysFirstCalc
{          //This is basic Calculator. It is lacking a check for putting in something that is not a float into val1 and val2. Doing so currently breaks the system. 
    internal class Calc
    {
        static void Main()
        {
            float val1 = 0;
            float val2 = 0;
            float val3 = 0;

            Console.WriteLine("Welcome to the Calculator");
            Console.WriteLine("Please enter your first number:");

            val1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number:");

            val2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What would you like to do? Type one of the following:");
            Console.WriteLine("Add, Multiply, Divide, or Subtract?");
            string equation = Console.ReadLine();

            if (equation == "Add")
            {
                val3 = val1 + val2;
                Console.WriteLine("Your result is " + val3);
                Main();
            }
            else if (equation == "Subtract")
            {
                val3 = val1 - val2;
                Console.WriteLine("Your result is " + val3);
                Main();
            }
            else if (equation == "Multiply")
            {
                val3 = val1 * val2;
                Console.WriteLine("Your result is " + val3);
                Main();
            }
            else if (equation == "Divide")
            {
                val3 = val1 % val2;
                Console.WriteLine("Your result is " + val3);
                Main();
            }
            else
            {
                Console.WriteLine("Your selection was not valid. Please type it in EXACTLY as presented:");
                Main();
            }
        }
    }
}