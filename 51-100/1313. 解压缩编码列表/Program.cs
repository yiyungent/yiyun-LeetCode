using System;
using System.Collections.Generic;

namespace _1313._解压缩编码列表
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/decompress-run-length-encoded-list/

            Console.WriteLine(string.Join(", ", DecompressRLElist(new int[] { 1, 2, 3, 4 })));

        }

        #region 方法1: 模拟
        /// <summary>
        /// 时间复杂度: O(n + ∑nums_even)  n 是数组nums长度，∑nums_even 是数组 nums 中所有下标为偶数的元素之和
        /// 空间复杂度: O(∑nums_even)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        static int[] DecompressRLElist(int[] nums)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i += 2)
            {
                // 频次
                for (int j = 0; j < nums[i]; j++)
                {
                    // 出现这么多次的数字
                    list.Add(nums[i + 1]);
                }
            }

            return list.ToArray();
        }
        #endregion

    }
}
