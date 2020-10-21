using System;
using System.Collections.Generic;

namespace _771._宝石与石头
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/jewels-and-stones/
            string J = "aA";
            string S = "aAAbbbb";
            Console.WriteLine(NumJewelsInStones(J, S));
        }

        #region 方法1
        ///// <summary>
        ///// 时间复杂度: O(mn) 其中 m 是字符串 J 的长度，n 是字符串 S 的长度
        ///// 空间复杂度: O(1) 只需要维护常量的额外空间
        ///// </summary>
        ///// <param name="J"></param>
        ///// <param name="S"></param>
        ///// <returns></returns>
        //static int NumJewelsInStones(string J, string S)
        //{
        //    int count = 0;
        //    foreach (var item in S)
        //    {
        //        foreach (var ch in J)
        //        {
        //            if (ch == item)
        //            {
        //                count++;
        //                break;
        //            }
        //        }
        //    }
        //    return count;
        //}
        #endregion

        #region 方法2: 哈希集合
        /// <summary>
        /// 时间复杂度：O(m+n)
        /// 空间复杂度：O(m)
        /// </summary>
        /// <param name="J"></param>
        /// <param name="S"></param>
        /// <returns></returns>
        static int NumJewelsInStones(string J, string S)
        {
            HashSet<char> jewelsSet = new HashSet<char>();
            for (int i = 0; i < J.Length; i++)
            {
                jewelsSet.Add(J[i]);
            }
            int count = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (jewelsSet.Contains(S[i]))
                {
                    count++;
                }
            }

            return count;
        }
        #endregion

    }
}
