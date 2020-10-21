using System;
using System.Collections.Generic;

namespace _283._移动零
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 0, 3, 12 };
            MoveZeroes(arr);
            Console.WriteLine(string.Join(" ", arr));
        }

        #region 方法1
        /// <summary>
        /// 时间复杂度: O(n)
        /// 空间复杂度: O(n)
        /// </summary>
        /// <param name="nums"></param>
        //static void MoveZeroes(int[] nums)
        //{
        //    int zeroCount = 0;
        //    foreach (var item in nums)
        //    {
        //        if (item == 0)
        //        {
        //            zeroCount++;
        //        }
        //    }
        //    List<int> list = new List<int>();
        //    foreach (var item in nums)
        //    {
        //        if (item != 0)
        //        {
        //            list.Add(item);
        //        }
        //    }
        //    for (int i = 0; i < zeroCount; i++)
        //    {
        //        list.Add(0);
        //    }
        //    // 注意：这么赋值，是新引用地址，不会改变方法外部实参
        //    //nums = list.ToArray();
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        nums[i] = list[i];
        //    }
        //}
        #endregion

        #region 方法2: 空间最优，操作局部优化（双指针）
        /// <summary>
        /// 时间复杂度: O(n)
        /// 空间复杂度: O(1)
        /// </summary>
        /// <param name="nums"></param>
        static void MoveZeroes(int[] nums)
        {
            int lastNonZeroFoundAt = 0;
            // If the current element is not 0, then we need to
            // append it just in front of last non 0 element we found. 
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[lastNonZeroFoundAt++] = nums[i];
                }
            }
            // After we have finished processing new elements,
            // all the non-zero elements are already at beginning of array.
            // We just need to fill remaining array with 0's.
            for (int i = lastNonZeroFoundAt; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
        #endregion

    }
}
