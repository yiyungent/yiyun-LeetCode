using System;

namespace _1528._重新排列字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/shuffle-string/
            Console.WriteLine(RestoreString("codeleet", new int[] { 4, 5, 6, 7, 0, 2, 1, 3 }));

        }


        #region 方法1: 遍历
        /// <summary>
        /// 时间复杂度: O(n)
        /// 空间复杂度: O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="indices"></param>
        /// <returns></returns>
        static string RestoreString(string s, int[] indices)
        {
            char[] arr = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                arr[indices[i]] = s[i];
            }

            return string.Join("", arr);
        }
        #endregion


    }
}
