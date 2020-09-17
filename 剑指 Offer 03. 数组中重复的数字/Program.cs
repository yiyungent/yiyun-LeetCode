using System;
using System.Collections;
using System.Collections.Generic;

namespace 剑指_Offer_03._数组中重复的数字
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 1, 0, 2, 5, 3 };

            int result = FindRepeatNumber(nums);

            Console.WriteLine(result);

            Console.ReadLine();
        }

        #region 方法1: 暴力遍历: 超出时间限制
        //static int FindRepeatNumber(int[] nums)
        //{
        //    List<int> list = new List<int>();
        //    foreach (int num in nums)
        //    {
        //        if (list.Contains(num))
        //        {
        //            return num;
        //        }

        //        list.Add(num);
        //    }

        //    return -1;
        //}
        #endregion

        #region 方法2: 原地交换
        /// <summary>
        /// 在一个长度为 n 的数组 nums 里的所有数字都在 0 ~ n-1 的范围内
        /// 说明: 数组元素的 索引 和 值 是  一对多 的关系
        /// 遍历数组，通过交换操作，使元素的索引与值一一对应（即nums[i]=i）
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        static int FindRepeatNumber(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] == i)
                {
                    // 已经处于一一对应，指针直接前进
                    i++;
                    continue;
                }
                // eg: nums[i] 为 5, 则应该出现在索引为5的位置, 其值也为 5
                // eg: nums[5] = 5
                // 该元素值（经过交换后）应该出现的位置 的值 == 此元素的值
                if (nums[nums[i]] == nums[i])
                {
                    // 当前元素值 , 在 前面 已出现 
                    return nums[i];
                }
                // 交换: 将元素交换到其值为索引的位置
                int temp = nums[i];
                nums[i] = nums[temp];
                nums[temp] = temp;
            }
            return -1;
        }
        #endregion
    }
}
