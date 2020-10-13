using System;

namespace _171._Excel表列序号
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/excel-sheet-column-number/
            Console.WriteLine(TitleToNumber("A"));
            Console.WriteLine(TitleToNumber("AB"));
            Console.WriteLine(TitleToNumber("ZY"));
        }

        #region 方法1: 倒序遍历，常规思路
        //static int TitleToNumber(string s)
        //{
        //    int rtn = 0;
        //    int temp = 0;
        //    int len = s.Length;
        //    // 倒序遍历
        //    for (int i = len - 1; i >= 0; i--)
        //    {
        //        // 'A' -> 1, 'B' -> 2
        //        temp = s[i] - 'A' + 1;
        //        // 'A'-'Z' 26个字母 -> 26 进制
        //        rtn += temp * (int)Math.Pow(26, len - i - 1);
        //    }
        //    return rtn;
        //}
        #endregion


        #region 方法2：正序遍历
        static int TitleToNumber(string s)
        {
            int ans = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int num = s[i] - 'A' + 1;
                ans = ans * 26 + num;
            }
            return ans;
        }
        #endregion

    }
}
