using System;
using System.Linq;

namespace _4_Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // read a list of REAL numbers and print LARGEST 3 of them. If less than 3 numbers exit, print all of them.
            Console.WriteLine(string.Join(" ", 
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x=>x)
                .Take(3)
                .ToArray()));
        }
        // we make direct print of a concatenated string array made from the input (console) and splitted, parsed to int, ordered by descending, take 3 (largest) and then made in array
    }
}
