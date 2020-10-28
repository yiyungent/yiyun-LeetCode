using System;

namespace _268._丢失的数字
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/missing-number/


            Console.WriteLine(MissingNumber(new int[] { 3, 0, 1 }));
        }

        #region 方法1: 数学
        ///// <summary>
        ///// 时间复杂度: O(n)
        ///// 空间复杂度: O(1)
        ///// </summary>
        ///// <param name="nums"></param>
        ///// <returns></returns>
        //static int MissingNumber(int[] nums)
        //{
        //    int n = nums.Length;
        //    // 当数过大时，有溢出风险
        //    int expectedSum = n * (n + 1) / 2;
        //    int actualSum = 0;
        //    foreach (var item in nums)
        //    {
        //        actualSum += item;
        //    }

        //    return expectedSum - actualSum;
        //}
        #endregion

        #region 方法2: 数学+优化: 边加边减
        /// <summary>
        /// 时间复杂度: O(n)
        /// 空间复杂度: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        static int MissingNumber(int[] nums)
        {
            // 注意: 由于 值是 0-nums.Length, 下标到不了 nums.Length，所以先初始化加上这个
            int sum = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                // 方法1: (0+1+2+3) - (3+0+1)
                // 此方法: 加法的交换律: 3   (+0 -3) (+1 -0) (+2 -1)
                sum += i;
                sum -= nums[i];
            }

            return sum;
        }
        #endregion

    }
}
