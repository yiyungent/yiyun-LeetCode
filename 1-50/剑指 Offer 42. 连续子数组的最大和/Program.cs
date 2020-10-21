using System;

namespace 剑指_Offer_42._连续子数组的最大和
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/lian-xu-zi-shu-zu-de-zui-da-he-lcof/
            Console.WriteLine(MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }

        #region 方法1: 动态规划
        /// <summary>
        /// TODO: 没懂
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        static int MaxSubArray(int[] nums)
        {
            int res = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += Math.Max(nums[i - 1], 0);
                res = Math.Max(res, nums[i]);
            }
            return res;
        }
        #endregion



    }
}
