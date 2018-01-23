using System;
using System.Text;

namespace _1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Compress("aaaaabccccddeeeeccaa"));
            Console.WriteLine(Compress("aaaaabccccddeeeecca"));
            Console.WriteLine(Compress("aaaaabccccddeeeeccaaaaa"));
            Console.WriteLine(Compress("aaaaabccccddeeeeccaaaac"));
            Console.WriteLine(Compress(""));
            Console.WriteLine(Compress("aaaa"));
            Console.ReadLine();
        }

        public static string Compress(string uncompressedString)
        {
            StringBuilder compressedString = new StringBuilder();
            if (string.IsNullOrEmpty(uncompressedString))
                return string.Empty;
            if (uncompressedString.Length == 1)
                return uncompressedString;
            char[] uncompressedStringArray = uncompressedString.ToCharArray();
            int characterCount = 0;
            char prevChar = new char();

            for (int i = 1; i < uncompressedString.Length; i++)
            {
                prevChar = uncompressedString[i - 1];
                characterCount++;
                //compressedString.Append(prevChar);
                if (prevChar == uncompressedString[i])
                {
                    continue;
                }
                else
                {
                    compressedString.Append(prevChar);
                    compressedString.Append(characterCount);
                    characterCount = 0;
                }
            }
            compressedString.Append(prevChar);
            compressedString.Append(++characterCount);
            return compressedString.ToString();
        }
    }
}
