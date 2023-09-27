using System;

namespace BabysFirstCalculator
{
    public class Calc
    {
        int x = 0;
        int y = 0;

        Console.WriteLine("Booting Up Calculator");
        Console.ReadKey("Please enter value x:");

        public virtual int AddValues(int x, int y)
        {
            return x + y;
        }

        public virtual int SubValues(int x, int y)
        {
            return x - y;
        }

    }
}