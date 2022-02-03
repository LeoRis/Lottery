using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_The_Lottery
{
    public class Algorithms
    {
        private int elementLevel = -1;
        private int numberOfElements;
        private int[] permutationValue = new int[0];

        public char[] InputSet { get; set; }

        public int PermutationCount { get; set; }
        public char[] MakeCharArray(string InputString)
        {
            char[] charString = InputString.ToCharArray();
            Array.Resize(ref permutationValue, charString.Length);
            numberOfElements = charString.Length;
            return charString;
        }
        public void Recursion(int k)
        {
            elementLevel++;
            permutationValue.SetValue(elementLevel, k);

            if (elementLevel == numberOfElements)
            {
                OutputPermutation(permutationValue);
            }
            else
            {
                for (int i = 0; i < numberOfElements; i++)
                {
                    if (permutationValue[i] == 0)
                    {
                        Recursion(i);
                    }
                }
            }
            elementLevel--;
            permutationValue.SetValue(0, k);
        }
        private void OutputPermutation(int[] value)
        {
            foreach (int i in value)
            {
                Console.Write(InputSet.GetValue(i - 1));
            }
            Console.WriteLine();
            PermutationCount++;
        }
    }
}
