using System;
using System.Collections;
using System.Collections.Generic;

namespace _1614._括号的最大嵌套深度
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/maximum-nesting-depth-of-the-parentheses/
            // 注意: 题目数据保证括号表达式 s 是 有效的括号表达式
            Console.WriteLine(MaxDepth("(1+(2*3)+((8)/4))+1"));
            Console.WriteLine(MaxDepth("(1)+((2))+(((3)))"));
            Console.WriteLine(MaxDepth("1+(2*3)/(2-1)"));
            Console.WriteLine(MaxDepth("1"));
        }


        #region 方法1: 栈
        //static int MaxDepth(string s)
        //{
        //    Stack<char> stack = new Stack<char>();
        //    int maxDepth = 0;
        //    foreach (char ch in s)
        //    {
        //        if (ch == '(')
        //        {
        //            stack.Push(ch);
        //        }
        //        else if (ch == ')')
        //        {
        //            // 没有必要放到后面每次都比较，因为最大值一定是在出栈的时候出现
        //            // 记录栈的最大长度
        //            maxDepth = Math.Max(stack.Count, maxDepth);

        //            stack.Pop();
        //        }
        //    }

        //    return maxDepth;
        //}
        #endregion


        #region 方法2
        /// <summary>
        /// 注意: 题目数据保证括号表达式 s 是 有效的括号表达式
        /// 所以是无需关注是否是有效括号，只需探测深度
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static int MaxDepth(string s)
        {
            if (s.Length == 0) return 0;
            int maxDepth = 0, left = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    left++;
                    // 只要最大深度(最大嵌套层度)
                    if (left > maxDepth) maxDepth = left;
                }
                else if (s[i] == ')')
                {
                    left--;
                }
            }

            return maxDepth;
        }
        #endregion



    }
}
