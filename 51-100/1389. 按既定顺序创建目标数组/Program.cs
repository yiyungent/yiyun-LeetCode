using System;
using System.Collections.Generic;

namespace _1389._按既定顺序创建目标数组
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/create-target-array-in-the-given-order/

            int[] nums = new int[] { 0, 1, 2, 3, 4 };
            int[] index = new int[] { 0, 1, 2, 2, 1 };
            Console.WriteLine(string.Join(", ", CreateTargetArray(nums, index)));


        }

        #region 方法1: 模拟
        static int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < index.Length; i++)
            {
                // 注意: List.Insert() 将元素插入在前，实际会移动之后的元素，时间复杂度提升
                // TODO: 改为链表，链表的插入，不用移动这么多元素
                list.Insert(index[i], nums[i]);
            }

            return list.ToArray();
        }
        #endregion

    }
}
