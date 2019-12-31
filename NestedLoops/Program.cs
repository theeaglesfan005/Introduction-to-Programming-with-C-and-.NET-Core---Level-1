using System;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                    1   2   3   4   5
                1   1   2   3   4   5
                2   2   4   6   8   10    
            */

            Console.WriteLine("   1   2   3   4   5");

            for (int i = 1; i <= 2; i++)
            {
                Console.Write($"{i}  ");
                for(int j = 1; j <= 5; j++)
                {
                    Console.Write($"{i*j}   ");
                }
                Console.WriteLine();
            }
        }
    }
}
