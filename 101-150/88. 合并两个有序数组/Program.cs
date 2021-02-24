using System;

namespace _88._合并两个有序数组
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/merge-sorted-array/




            Console.WriteLine("Hello World!");
        }

        #region 方法一：双指针/从前往后
        /// <summary>
        /// https://leetcode-cn.com/problems/merge-sorted-array/solution/he-bing-liang-ge-you-xu-shu-zu-by-leetco-qn2i/
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = 0, p2 = 0;
            int[] sorted = new int[m + n];
            int cur;
            while (p1 < m || p2 < n)
            {
                if (p1 == m)
                {
                    cur = nums2[p2++];
                }
                else if (p2 == n)
                {
                    cur = nums1[p1++];
                }
                else if (nums1[p1] < nums2[p2])
                {
                    cur = nums1[p1++];
                }
                else
                {
                    cur = nums2[p2++];
                }
                sorted[p1 + p2 - 1] = cur;
            }
            for (int i = 0; i != m + n; i++)
            {
                nums1[i] = sorted[i];
            }
        }
        #endregion


    }
}
