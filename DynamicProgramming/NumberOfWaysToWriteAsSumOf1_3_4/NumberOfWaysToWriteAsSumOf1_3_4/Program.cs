using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfWaysToWriteAsSumOf1_3_4
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = 7;
            int[] array = new int[n+1];
            array[0] = array[1] = array[2] = 1;
            array[3] = 2;
            int result = NumberOfWays(n, array);
            Console.WriteLine(result);
        }

        static int NumberOfWays(int n, int[] array)
        {
            for (int i = 4; i <= n; i++)
            {
                array[i] = array[i - 1] + array[i - 3] + array[i - 4];
            }
            return array[n];
        }
    }
}
