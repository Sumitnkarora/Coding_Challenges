using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinStepsToOneByReducing
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            int target = 4;
            int[] preCalculatedResults = new int[target];
            Console.WriteLine(CalculateMinStepsDP(target, preCalculatedResults));
            DateTime end = DateTime.Now;
            Console.WriteLine(end.Subtract(start).Milliseconds.ToString());
            Console.ReadLine();
        }

        /// <summary>
        /// 1 + min( F(n-1), F(n/2), F (n/3)  )
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        static int CalculateMinStepsDP(int target, int[] preCalculatedResults)
        {
            if (target < 0)
            {
                Console.WriteLine("Values lesser than 0 are not supported");
                return 0;
            }
            if (target <= 3)
                return 1;
            
            if (preCalculatedResults[target-1] != 0)
                return preCalculatedResults[target-1];
            preCalculatedResults[0] = 1;
            preCalculatedResults[1] = 1;
            preCalculatedResults[2] = 1;
            preCalculatedResults[3] = 1;
            for (int i = 4; i < target; i++)
            {
                preCalculatedResults[i] = 1 + Math.Min(CalculateMinStepsDP(i - 1, preCalculatedResults), Math.Min(i % 2 == 0 ? (CalculateMinStepsDP(i / 2 , preCalculatedResults)) : int.MaxValue, 
                                                                                            i%3 == 0 ? CalculateMinStepsDP(i / 3, preCalculatedResults): int.MaxValue));
            }
            return preCalculatedResults[target - 1];
        }
    }
}
