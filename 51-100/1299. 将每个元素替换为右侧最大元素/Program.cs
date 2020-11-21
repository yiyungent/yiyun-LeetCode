using System;

namespace _1299._将每个元素替换为右侧最大元素
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/replace-elements-with-greatest-element-on-right-side/

            Console.WriteLine(string.Join(", ", new Solution().ReplaceElements(new int[] { 17, 18, 5, 4, 6, 1 })));

        }
    }


    public class Solution
    {


        #region 方法1: 逆序遍历
        /// <summary>
        /// 逆序地遍历整个数组，同时维护从数组右端到当前位置所有元素的最大值
        /// 时间复杂度: O(n) ，n 为 数组 arr 长度
        /// 空间复杂度: O(1) , 除了存储答案的 数组 ans 外，额外的空间复杂度 O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] ReplaceElements(int[] arr)
        {
            int n = arr.Length;
            int[] ans = new int[n];
            ans[n - 1] = -1;
            for (int i = n - 2; i >= 0; i--)
            {
                ans[i] = Math.Max(ans[i + 1], arr[i + 1]);
            }

            return ans;
        }
        #endregion


    }


}
