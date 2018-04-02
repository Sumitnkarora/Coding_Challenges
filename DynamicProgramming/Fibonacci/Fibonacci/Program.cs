using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        public static int RecursiveFib(int n)
        {
            if (n < 2)
                return 1;
            return RecursiveFib(n - 1) + RecursiveFib(n - 2);
        }

        public static void DPFibonacci(int n, int[] array)
        {

            array[0] = 1;
            array[1] = 1;
            for (int i = 2; i < array.Count(); i++)
                array[i] = array[i - 1] + array[i - 2];
        }

        public static void Main(string[] args)
        {
            int n = 5;
            int x = RecursiveFib(n);
            Console.WriteLine(x.ToString());
            int[] array = new int[6];
            DPFibonacci(n, array);
            
            Console.ReadLine();
        }
    }
}
