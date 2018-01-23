using System;
using System.Linq;

namespace Knapsack_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfCoins = {1,2,3};
            int desiredValue = 36;
            int numberOfCoins = NumberOfCoins(arrayOfCoins, desiredValue);
            Console.Write(numberOfCoins);
            Console.ReadKey();
        }

        static int NumberOfCoins(int []coins, int desiredValue)
        {
            int[] preCalculatedResults = new int[desiredValue];

            for (int i=0;i<preCalculatedResults.Length; i++)
            {
                preCalculatedResults[i] = 1000000000;
            }

            preCalculatedResults[0] = 0;

            if (desiredValue == 0)
            {
                return preCalculatedResults[0];
            }
            //if (desiredValue == 1)
            //{
            //    return 1;
            //}
            if (desiredValue < 0)
            {
                return 1000000000;
            }
            
            for (int j = 0; j < desiredValue; ++j)
            {
                int[] minCoinsCombination = new int[coins.Length];
                for (int i = 0; i < coins.Length; i++)
                {
                    //minCoinsCombination[i] = NumberOfCoins(coins, preCalculatedResults[desiredValue] - coins[i]);
                    //minCoinsCombination[i] = NumberOfCoins(coins, desiredValue - coins[i]);
                    try
                    {
                        minCoinsCombination[i] = preCalculatedResults[j - coins[i]];
                    }
                    catch (Exception ex)
                    {
                        
                    }
                }

                preCalculatedResults[j] =  1 + minCoinsCombination.Min();
            }

            return preCalculatedResults[desiredValue -1];
        }
    }
}
