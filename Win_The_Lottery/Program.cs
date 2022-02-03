using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_The_Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the desired characters:");
            string input = Console.ReadLine();

            Algorithms permutationAlgorithm = new Algorithms();
            permutationAlgorithm.InputSet = permutationAlgorithm.MakeCharArray(input);

            permutationAlgorithm.Recursion(0);
            Console.Write("Number of Permutations: " + permutationAlgorithm.PermutationCount);

            Console.ReadKey();
        }
    }
}
