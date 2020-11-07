using System;

namespace _1295._统计位数为偶数的数字
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindNumbers(new int[] { 12, 345, 2, 6, 7896 }));
        }

        #region 方法1: 枚举+字符串
        static int FindNumbers(int[] nums)
        {
            int rtn = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i].ToString().Length & 1) != 1)
                {
                    // 位数 为 偶数
                    rtn++;
                }
            }

            return rtn;
        }
        #endregion

    }
}
