// A1519
// Lab 6
// October 30, 2016
// CIS 199-01

// This program outputs a series of stars in 4 various patterns.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Stars
    {
        static void Main(string[] args)
        {
            const int MAX_ROWS = 10; // Defines the max number of rows there will be for each pattern

            Console.WriteLine("Pattern A");
            Console.WriteLine();
            for (int rows = 1; rows <= MAX_ROWS; rows++) // For-Loop for Pattern A
            {
                for (int stars = 1; stars <= rows; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Pattern B");
            Console.WriteLine();
            for (int rows = MAX_ROWS; rows >= 1; rows--) // For-Loop for Pattern B
            {
                for (int stars = rows; stars >= 1; stars--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Pattern C");
            Console.WriteLine();
            for (int rows = MAX_ROWS; rows >= 1; rows--) // For-Loop for Pattern C
            {
                int blanks; // Variable for placing number of blanks
                for (blanks = 0; blanks < MAX_ROWS - rows; blanks++)
                {
                    Console.Write(" ");
                }
                for (int stars = 1; stars <= MAX_ROWS - blanks; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Pattern D");
            Console.WriteLine();
            for (int rows = 1; rows <= MAX_ROWS; rows++) // For-Loop for Pattern D
            {
                int blanks; // Variable for placing number of blanks
                for (blanks = 0; blanks < MAX_ROWS - rows; blanks++)
                {
                    Console.Write(" ");
                }
                for (int stars = 1; stars <= MAX_ROWS - blanks; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
