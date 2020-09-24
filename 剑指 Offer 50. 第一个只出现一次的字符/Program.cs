using System;
using System.Collections.Generic;

namespace 剑指_Offer_50._第一个只出现一次的字符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstUniqChar("abaccdeff"));
            Console.WriteLine(FirstUniqChar(""));

            Console.ReadLine();
        }

        /// <summary>
        /// 有序哈希表/字典
        /// 时间复杂度: O(n)
        /// 空间复杂度: O(1)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static char FirstUniqChar(string s)
        {
            Dictionary<char, bool> dic = new Dictionary<char, bool>();
            // n次遍历 (n 字符串长度)
            foreach (char item in s)
            {
                // 不存在为 True, 已存在False
                if (dic.ContainsKey(item))
                {
                    dic[item] = false;
                }
                else
                {
                    dic.Add(item, true);
                }
            }
            // <=n次遍历
            foreach (char key in dic.Keys)
            {
                if (dic[key])
                {
                    return key;
                }
            }
            // 没有重复字符，返回 ' '
            return ' ';
        }
    }
}
