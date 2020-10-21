using System;

namespace _344._反转字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/reverse-string/
            {
                char[] chars = { 'h', 'e', 'l', 'l', 'o' };
                ReverseString(chars);
                Console.WriteLine(string.Join(", ", chars));
            }
        }

        #region 方法1
        ///// <summary>
        ///// 空间复杂度: O(1)
        ///// 时间复杂度: O(n)
        ///// </summary>
        ///// <param name="s"></param>
        //static void ReverseString(char[] s)
        //{
        //    char temp;
        //    for (int i = 0; i < s.Length / 2; i++)
        //    {
        //        temp = s[s.Length - i - 1];
        //        s[s.Length - i - 1] = s[i];
        //        s[i] = temp;
        //    }
        //}
        #endregion

        #region 方法二: 对撞双指针，相遇即结束
        /// <summary>
        /// 时间复杂度: O(n)
        /// 空间复杂度: O(1)
        /// </summary>
        /// <param name="s"></param>
        static void ReverseString(char[] s)
        {
            char temp;
            for (int left = 0, right = s.Length - 1; left < right; left++, right--)
            {
                temp = s[left];
                s[left] = s[right];
                s[right] = temp;
            }
        }
        #endregion

    }
}
