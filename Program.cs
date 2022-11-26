using System;
using System.Collections.Generic;


namespace payoutCombinations
{
    internal class Program
    {
        public static List<int> denominations = new List<int> { 10, 50, 100 };
        public static void Main(string[] args)
        {
            List<int> amount = new List<int>() { 100, 30, 50, 60, 80, 140, 230, 370, 610, 980 };


            foreach (var item in amount)
            {
                var result = payoutCombinations(0, item);
                Console.WriteLine("possible combination of payout for " + item + ":" + result);
            }

            Console.ReadLine();

        }

        public static int payoutCombinations(int idx, int target)
        {
            if (target == 0) return 1;
            var ways = 0;
            for (var i = idx; i < denominations.Count; i++)
            {
                if (target - denominations[i] >= 0)
                {
                    ways += payoutCombinations(i, target - denominations[i]);
                  
                }
            }

            return ways;

        }
    }
}
