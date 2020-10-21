using System;

namespace 剑指Offer05.替换空格
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "We are happy.";

            Console.WriteLine(ReplaceSpace(s));

            Console.ReadLine();
        }

        /// <summary>
        /// 时间复杂度: O(n) 遍历字符串s一遍
        /// 空间复杂度: O(n) 额外创建字符数组，长度为 s 的长度的3倍
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static string ReplaceSpace(string s)
        {
            int length = s.Length;
            // 最大长度: 假设字符串全为空格, 均需要替换, 则1字符换3字符
            char[] chars = new char[length * 3];
            // 指针: 真实最后替换后的字符串长度
            int size = 0;
            for (int i = 0; i < length; i++)
            {
                char ch = s[i];
                if (ch == ' ')
                {
                    // 是空格
                    // 指针移位，依次向后指
                    // PS: size++ 先赋值，后自增1
                    chars[size++] = '%';
                    chars[size++] = '2';
                    chars[size++] = '0';
                }
                else
                {
                    // 不是空格，赋值，指针+
                    chars[size++] = ch;
                }
            }

            string newStr = new string(chars, 0, size);

            return newStr;
        }
    }
}
