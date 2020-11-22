using System;

namespace _1460._通过翻转子数组使两个数组相等
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/make-two-arrays-equal-by-reversing-sub-arrays/

            int[] target = new int[] { 1, 2, 3, 4 };
            int[] arr = { 2, 4, 1, 3 };
            Console.WriteLine(new Solution().CanBeEqual(target, arr));


        }
    }

    public class Solution
    {

        #region 方法1
        /// <summary>
        /// 只要两个数组的元素是相同的，不管经过多少次翻转，一定可以实现
        /// </summary>
        /// <param name="target"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        public bool CanBeEqual(int[] target, int[] arr)
        {
            if (target.Length != arr.Length)
            {
                return false;
            }
            Array.Sort(target);
            Array.Sort(arr);
            for (int i = 0; i < target.Length; i++)
            {
                // 排序后只要有一个不同，则不同
                if (target[i] != arr[i])
                {
                    return false;
                }
            }

            return true;
        }
        #endregion

    }

}
