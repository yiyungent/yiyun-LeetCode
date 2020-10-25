using System;

namespace LCP_06._拿硬币
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 2, 1 };
            Console.WriteLine(MinCount(nums));
        }

        #region 方法1
        static int MinCount(int[] coins)
        {
            int rtn = 0;
            foreach (var item in coins)
            {
                rtn += (item + 1) / 2;
            }

            return rtn;
        }
        #endregion

    }
}
