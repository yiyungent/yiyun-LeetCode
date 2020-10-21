using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace 剑指_Offer_58___I._翻转单词顺序
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("the sky is blue"));
            Console.WriteLine(ReverseWords("  hello world!  "));
            Console.WriteLine(ReverseWords("a good   example"));
            Console.WriteLine(ReverseWords(" 1"));

            Console.ReadLine();
        }

        #region 方法一: 自己想的: 栈
        /// <summary>
        /// 执行用时： 100 ms , 在所有 C# 提交中击败了 88.57% 的用户
        /// 内存消耗： 24.5 MB , 在所有 C# 提交中击败了 54.10% 的用户
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        //static string ReverseWords(string s)
        //{
        //    if (s == null || s.Length == 0 || string.IsNullOrWhiteSpace(s))
        //    {
        //        return "";
        //    }
        //    Stack<string> stack = new Stack<string>();
        //    StringBuilder sbTemp = new StringBuilder();
        //    // 最后加个空格, 用于最后的单词
        //    s = s + " ";
        //    foreach (char ch in s)
        //    {
        //        if (ch != ' ')
        //        {
        //            sbTemp.Append(ch);
        //        }
        //        else if (ch == ' ' && sbTemp.Length != 0)
        //        {
        //            stack.Push(sbTemp.ToString());
        //            sbTemp.Clear();
        //        }
        //    }
        //    StringBuilder sb = new StringBuilder();
        //    int size = stack.Count;
        //    for (int i = 0; i < size; i++)
        //    {
        //        sb.Append(stack.Pop() + " ");
        //    }
        //    // 移除最后的空格
        //    sb.Remove(sb.Length - 1, 1);

        //    return sb.ToString();
        //}
        #endregion

        #region 方法二: 双指针
        static string ReverseWords(string s)
        {
            // 去掉首尾空格
            s = s.Trim();
            // j 指向单词单词末，i指向单词首(前一个位置的空格)
            int j = s.Length - 1, i = j;
            StringBuilder sb = new StringBuilder();
            while (i >= 0)
            {
                while (i >= 0 && s[i] != ' ') i--;  // 从右向左搜索: 搜索首个空格: i 指向它(它也就是单词首的空格)

                // 注意: Java 中 public String substring(int beginIndex, int endIndex)
                // C# public String Substring(int beginIndex, int length)
                //sb.Append(s.Substring(i + 1, j - (i + 1) + 1) + " ");
                sb.Append(s.Substring(i + 1, j - i) + " ");

                while (i >= 0 && s[i] == ' ') i--; // 从右向左移动: 跳过所有空格
                j = i; // j 指向下个单词的尾字符
            }
            // 最后 i 会为 -1, 因为字符串前无空格, 依然可行
            return sb.ToString().Trim();
        }
        #endregion
    }
}
