using System;

namespace _1_2_PermutationOfAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isPermutation("arora","raaro"));
            Console.WriteLine(isPermutation("arora", "raar"));
            Console.ReadLine();
        }

        public static bool isPermutation(string input1, string input2)
        {
            if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
                return false;
            if (input1.Length != input2.Length)
                return false;
            bool[] referenceArray = new bool[127];
            char[] input1Arr = input1.ToCharArray();
            char[] input2Arr = input2.ToCharArray();
            int asciiIndex;
            for (int i = 0; i < input1Arr.Length; i++)
            {
                asciiIndex = input1Arr[i];
                referenceArray[asciiIndex] = true;
            }

            for (int i = 0; i < input2Arr.Length; i++)
            {
                asciiIndex = input2Arr[i];
                referenceArray[asciiIndex] = false;
            }

            for (int i = 0; i < referenceArray.Length; i++)
            {
                if (referenceArray[i])
                    return false;
            }
            return true;
        }
    }
}
