using System;

namespace _136._只出现一次的数字
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/single-number/


            Console.WriteLine(SingleNumber(new int[] { 2, 2, 1 }));
            Console.WriteLine(SingleNumber(new int[] { 4, 1, 2, 1, 2 }));

        }

        #region 方法1: 位运算
        /// <summary>
        /// 时间复杂度：O(n)
        /// 空间复杂度：O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        static int SingleNumber(int[] nums)
        {
            int ret = 0;
            foreach (int e in nums) ret ^= e;
            return ret;
        }
        #endregion

    }
}
