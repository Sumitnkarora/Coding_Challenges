using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveSumOfNestedArray
{
    class Program
    {
        static int[] array = { 10, 20, 30 };
        static void Main(string[] args)
        {
            int x = SumArray(array, array.Length);
            Console.WriteLine(x);
            Console.ReadLine();
        }

        static int SumArray(int[] array, int length)
        {
            if (length <= 1)
                return array[0];
            return array[length - 1] + SumArray(array, length - 1);
        }
    }
}
