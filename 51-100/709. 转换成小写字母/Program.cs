using System;
using System.Text;

namespace _709._转换成小写字母
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/to-lower-case/


            Console.WriteLine(new Solution().ToLowerCase("Hello"));
            Console.WriteLine(new Solution().ToLowerCase("here"));
            Console.WriteLine(new Solution().ToLowerCase("LOVELY"));


        }
    }

    public class Solution
    {


        #region 方法1
        //public string ToLowerCase(string str)
        //{
        //    char[] arr = str.ToCharArray();
        //    // ASCII码: 
        //    // A-Z: 65-90
        //    // a-z: 97-122
        //    // a - A = 32
        //    // a = A + 32
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] >= 65 && arr[i] <= 90)
        //        {
        //            // 大写字母 转小写
        //            arr[i] = (char)(arr[i] + 32);
        //        }
        //    }

        //    return string.Join("", arr);
        //}
        #endregion

        #region 方法2
        public string ToLowerCase(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char item in str)
            {
                if (item >= 'A' && item <= 'Z')
                {
                    sb.Append((char)(item + 32));
                }
                else
                {
                    sb.Append(item);
                }
            }

            return sb.ToString();
        }
        #endregion


    }

}
