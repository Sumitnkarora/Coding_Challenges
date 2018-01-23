using System;

namespace _1_8_RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] inputMatrix = new string[4,4];
            inputMatrix[0, 0] = "00";
            inputMatrix[0, 1] = "01";
            inputMatrix[0, 2] = "02";
            inputMatrix[0, 3] = "03";

            inputMatrix[1, 0] = "10";
            inputMatrix[1, 1] = "11";
            inputMatrix[1, 2] = "12";
            inputMatrix[1, 3] = "13";


            inputMatrix[2, 0] = "20";
            inputMatrix[2, 1] = "21";
            inputMatrix[2, 2] = "22";
            inputMatrix[2, 3] = "23";


            inputMatrix[3, 0] = "30";
            inputMatrix[3, 1] = "31";
            inputMatrix[3, 2] = "32";
            inputMatrix[3, 3] = "33";


            RotateMatrix(inputMatrix);
            //DisplayMatrix(inputMatrix);
            Console.ReadLine();
        }

        public static void RotateMatrix(string[,] inputMatrix)
        {
            int length = inputMatrix.GetLength(0);
            for (int i = 0; i < length/ 2; i++)
            {
                for (int j = i; j < length - i; j++)
                {
                    Console.WriteLine(i.ToString() + " " + j.ToString());
                }
                Console.WriteLine();
            }
            
            
        }

        

        private static void DisplayMatrix(int[,] inputMatrix)
        {
            for (int i = 0; i < inputMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < inputMatrix.GetLength(1); j++)
                {
                    Console.Write(inputMatrix[i,j] + "   ");
                }
                Console.WriteLine("");
            }
        }
    }
}
