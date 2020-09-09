using System;
using System.Collections.Generic;

namespace 有效的括号
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "()";
            Console.WriteLine(IsValid(str1));
            string str2 = "()[]{}";
            Console.WriteLine(IsValid(str2));
            string str3 = "(]";
            Console.WriteLine(IsValid(str3));
            string str4 = "([)]";
            Console.WriteLine(IsValid(str4));
            string str5 = "{[]}";
            Console.WriteLine(IsValid(str5));
        }

        #region 栈
        static bool IsValid(string s)
        {
            // key: 右括号 value: 左括号
            Dictionary<char, char> dic = new Dictionary<char, char>()
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };
            Stack<char> stack = new Stack<char>();
            //Queue<char> stack = new Queue<char>();
            foreach (char ch in s)
            {
                if (dic.ContainsKey(ch))
                {
                    // 是 右括号
                    if (stack.Count == 0 || stack.Peek() != dic[ch])
                    {
                        // 栈为空 或 栈顶字符 不匹配此右括号
                        return false;
                    }

                    // 弹出栈中匹配的左括号
                    stack.Pop();
                }
                else
                {
                    // 压入 左括号
                    stack.Push(ch);
                }
            }

            // 最后为空则说明括号完全匹配，有效括号
            return stack.Count == 0;
        }
        #endregion
    }
}
