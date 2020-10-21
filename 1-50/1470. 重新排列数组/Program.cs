using System;

namespace _1470._重新排列数组
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/shuffle-the-array/

            int[] nums = { 2, 5, 1, 3, 4, 7 };
            int n = 3;
            foreach (var item in Shuffle(nums, n))
            {
                Console.Write(item + " ");
            }

        }

        #region 方法1
        /// <summary>
        /// 空间复杂度: O(n)
        /// 时间复杂度: O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        //static int[] Shuffle(int[] nums, int n)
        //{
        //    int[] rtn = new int[nums.Length];
        //    for (int i = 0, j = 0; j < n; i += 2, j++)
        //    {
        //        // i指向返回数组, j指向 原数组
        //        rtn[i] = nums[j];
        //        rtn[i + 1] = nums[j + n];
        //    }

        //    return rtn;
        //}
        #endregion


        #region 方法2
        /// <summary>
        /// 空间复杂度: O(n)
        /// 时间复杂度: O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static int[] Shuffle(int[] nums, int n)
        {
            int[] rtn = new int[n * 2];
            for (int i = 0; i < n; i++)
            {
                rtn[i * 2] = nums[i];
                rtn[i * 2 + 1] = nums[i + n];
            }

            return rtn;
        }
        #endregion

    }
}
