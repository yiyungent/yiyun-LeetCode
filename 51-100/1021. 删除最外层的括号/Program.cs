using System;
using System.Text;

namespace _1021._删除最外层的括号
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/remove-outermost-parentheses/

            Console.WriteLine(RemoveOuterParentheses("(()())(())"));

        }


        #region 方法1
        /// <summary>
        /// 处理对称字符串的时候设置一个num值 遇到一个‘（’就加一 遇到一个‘）’就减一 
        /// 最后等于0的时候就是对称的时候
        /// </summary>
        /// <param name="S"></param>
        /// <returns></returns>
        static string RemoveOuterParentheses(string S)
        {
            int num = 0;
            int start = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < S.Length; i++)
            {
                char c = S[i];
                if (c == '(')
                {
                    num++;
                }
                else if (c == ')')
                {
                    num--;
                }
                if (num == 0)
                {
                    // 添加时: 去掉外括号, 即 最前面 ( ，去掉末尾 )
                    // 所以才是 start + 1,   length: i - start - 1
                    sb.Append(S.Substring(start + 1, i - start - 1));
                    start = i + 1;
                }
            }

            return sb.ToString();
        }
        #endregion


    }
}
