using System;

namespace 剑指_Offer_57._和为s的两个数字
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSum(nums, target);
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }

        }

        #region 方法1: 暴力遍历: 超出时间限制
        //static int[] TwoSum(int[] nums, int target)
        //{
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        for (int j = i + 1; j < nums.Length; j++)
        //        {
        //            if (nums[i] + nums[j] == target)
        //            {
        //                return new int[] { nums[i], nums[j] };
        //            }
        //        }
        //    }

        //    return null;
        //}
        #endregion

        #region 方法2: 对撞双指针
        /// <summary>
        /// 时间复杂度: O(n): n为数组长度, 双指针共同作用遍历完数组(一次遍历)
        /// 空间复杂度: O(1): 变量i,j使用常数大小的额外空间
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        static int[] TwoSum(int[] nums, int target)
        {
            // 双指针 分别指向数组两端
            // i: 头 : 当 sum = nums[i] + nums[j] < target 时, i 向右移动1位 
            int i = 0;
            // j: 末 : 当 sum = nums[i] + nums[j] > target 时, j 向左移动1位
            int j = nums.Length - 1;
            int sum = 0;
            while (i < j)
            {
                // i=j时，即指针对撞，此时两个共同作用下遍历完数组，退出循环
                sum = nums[i] + nums[j];
                if (sum < target)
                {
                    i++;
                }
                else if (sum > target)
                {
                    j--;
                }
                else
                {
                    return new int[] { nums[i], nums[j] };
                }

            }

            return new int[] { };
        }
        #endregion
    }
}
