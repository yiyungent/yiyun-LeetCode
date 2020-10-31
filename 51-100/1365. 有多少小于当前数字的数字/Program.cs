using System;
using System.Collections.Generic;
using System.Linq;

namespace _1365._有多少小于当前数字的数字
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/how-many-numbers-are-smaller-than-the-current-number/

            Console.WriteLine(string.Join(", ", SmallerNumbersThanCurrent(new int[] { 8, 1, 2, 2, 3 })));

        }

        #region 方法一: 暴力遍历
        ///// <summary>
        ///// 空间复杂度: O(1)   注意我们不计算答案数组的空间占用
        ///// 时间复杂度: O(n^2)
        ///// </summary>
        ///// <param name="nums"></param>
        ///// <returns></returns>
        //static int[] SmallerNumbersThanCurrent(int[] nums)
        //{
        //    int[] rtn = new int[nums.Length];
        //    int count = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        count = 0;
        //        for (int j = 0; j < nums.Length; j++)
        //        {
        //            if (nums[j] < nums[i])
        //            {
        //                // 存在比它小的
        //                count++;
        //            }
        //        }
        //        rtn[i] = count;
        //    }

        //    return rtn;
        //}
        #endregion


        #region 方法二: 冒泡排序
        /// <summary>
        /// 从小到大排序后，元素索引 即代表 比元素小的元素数目
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            // 用来记录原数组 每个元素的位置
            int[] temp = new int[nums.Length];
            nums.CopyTo(temp, 0);

            // 冒泡排序
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        //int temp = nums[j];
                        //nums[j] = nums[j + 1];
                        //nums[j + 1] = temp;

                        nums[j] = nums[j] + nums[j + 1];
                        nums[j + 1] = nums[j] - nums[j + 1];
                        nums[j] = nums[j] - nums[j + 1];
                    }
                }
            }
            // 从小到大排序后，元素索引 即代表 比元素小的元素数目
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == temp[j])
                    {
                        nums[i] = i;
                    }
                }
            }
            // TODO: 未完成

            return nums;
        }
        #endregion

    }
}
