using System;

namespace _1_1_DuplicatesInArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine(isDuplicate("Arora").ToString());
            System.Console.WriteLine(isDuplicate("Sumit").ToString());
            System.Console.WriteLine(isDuplicate("AroA").ToString());
            System.Console.WriteLine(isDuplicate("").ToString());
            System.Console.WriteLine(isDuplicate("Nitika").ToString());

            System.Console.WriteLine(isDuplicate(null).ToString());
            Console.ReadLine();
        }

        public static bool isDuplicate(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;
            bool isDuplicate = false;
            char[] inputArray = input.ToCharArray();
            int[] referenceList = new int[256];
            int unicodePos;
            for (int i = 0; i < inputArray.Length; i++)
            {
                unicodePos = Convert.ToInt32(inputArray[i]);
                referenceList[unicodePos] += 1;
            }

            for (int i = 0; i < referenceList.Length; i++)
            {
                if (referenceList[i] >= 2)
                {
                    return true;
                }
                
            }
            return isDuplicate;
        }


    }
}
