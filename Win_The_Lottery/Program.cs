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

            Algorithms permAlgorithm = new Algorithms();
            permAlgorithm.InputSet = permAlgorithm.MakeCharArray(input);

            permAlgorithm.Recursion(0);
            Console.Write("# of Permutations: " + permAlgorithm.PermutationCount);

            Console.ReadKey();
        }
    }
}
