using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinStepsToOneByReducing
{
    class Program
    {
        public static int CountOfOperations { get; set; }
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            int target = 300;
            int arrayLength = target + 1;
            int[] preCalculatedResults = new int[arrayLength];
            preCalculatedResults[0] = 1;
            preCalculatedResults[1] = 1;
            preCalculatedResults[2] = 1;
            preCalculatedResults[3] = 1;
            Console.WriteLine(CalculateMinStepsDP(target, preCalculatedResults));
            Console.WriteLine(CountOfOperations);
            DateTime end = DateTime.Now;
            //Console.WriteLine(end.Subtract(start).Milliseconds.ToString());
            Console.ReadLine();
        }

        /// <summary>
        /// 1 + min( F(n-1), F(n/2), F (n/3)  )
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        static int CalculateMinStepsDP(int target, int[] preCalculatedResults)
        {
            CountOfOperations++;
            if (target < 0)
            {
                Console.WriteLine("Values lesser than 0 are not supported");
                return 0;
            }
            if (target <= 3)
                return 1;

            if (preCalculatedResults[target] != 0)
                return preCalculatedResults[target];

            for (int i = 4; i < target + 1; i++)
            {
                preCalculatedResults[i] = 1 + GetMinimumPath(i, preCalculatedResults);
            }
            return preCalculatedResults[target];
        }

        static int GetMinimumPath(int i, int[] preCalculatedResults)
        {
            int returnValue = 0;
            int conditionDivideByTwo = int.MaxValue, conditionDivideByThree = int.MaxValue;
            int conditionMinusOne = CalculateMinStepsDP(i - 1, preCalculatedResults);
            if (i % 2 == 0)
                conditionDivideByTwo = CalculateMinStepsDP(i / 2, preCalculatedResults);
            else
                conditionDivideByTwo = int.MaxValue;
            if (i % 3 == 0)
                conditionDivideByThree = CalculateMinStepsDP(i / 3, preCalculatedResults);
            else
                conditionDivideByThree = int.MaxValue;

            returnValue = Minimum(conditionMinusOne, conditionDivideByTwo, conditionDivideByThree);
            return returnValue;

        }

        static int Minimum(int a, int b, int c)
        {
            int retValue = Math.Min(a, Math.Min(b, c));
            return retValue;
        }

        int getMinSteps(int n, int[] preCalculatedResults)

        {
            if (n == 1) return 0;  // base case
            if (preCalculatedResults[n] != -1)
                return preCalculatedResults[n];  // we have solved it already :)
            int r = 1 + getMinSteps(n - 1, preCalculatedResults);  // '-1' step .  'r' will contain the optimal answer finally
            if (n % 2 == 0) r = Math.Min(r, 1 + getMinSteps(n / 2, preCalculatedResults));  //  '/2' step
            if (n % 3 == 0) r = Math.Min(r, 1 + getMinSteps(n / 3, preCalculatedResults));  //  '/3' step
            preCalculatedResults[n] = r;  // save the result. If you forget this step, then its same as plain recursion.
            return r;
        }
    }
}
