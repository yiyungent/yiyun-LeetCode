using System;

namespace _1480._一维数组的动态和
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/running-sum-of-1d-array/
            int[] nums = { 1, 2, 3, 4 };
            Console.WriteLine(string.Join(", ", RunningSum(nums)));

        }

        #region 方法1
        /// <summary>
        /// 时间复杂度: O(n)
        /// 空间复杂度: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        static int[] RunningSum(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums;
            }
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }

            return nums;
        }
        #endregion


    }
}
