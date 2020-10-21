using System;
using System.Text;

namespace 剑指_Offer_58___II._左旋转字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcdefg";
            int k = 2;
            Console.WriteLine(ReverseLeftWords(s, k));

        }

        #region 方法1: 遍历拼接
        /// <summary>
        /// 时间复杂度: O(n): 两次遍历共n
        /// 空间复杂度: O(n)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static string ReverseLeftWords(string s, int n)
        {
            StringBuilder sb = new StringBuilder();
            #region 遍历方法1
            //for (int i = n; i < s.Length; i++)
            //{
            //    sb.Append(s[i]);
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    sb.Append(s[i]);
            //}
            #endregion

            #region 遍历方法2: 利用取余简化代码
            for (int i = n; i < n + s.Length; i++)
            {
                sb.Append(s[i % s.Length]);
            }
            #endregion

            return sb.ToString();
        }
        #endregion



    }
}
