using System;

namespace _169._多数元素
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/majority-element/

            Console.WriteLine(MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }));
        }

        #region 方法1: 摩尔投票
        /// <summary>
        /// 时间复杂度: O(n) Boyer-Moore 算法只对数组进行了一次遍历
        /// 空间复杂度: O(1) Boyer-Moore 算法只需要常数级别的额外空间
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        static int MajorityElement(int[] nums)
        {
            // 候选 众数
            int candidate = 0;
            int count = 0;
            foreach (var num in nums)
            {
                if (count == 0)
                {
                    candidate = num;
                }
                count += (num == candidate) ? 1 : -1;
            }
            return candidate;
        }
        #endregion

    }
}
