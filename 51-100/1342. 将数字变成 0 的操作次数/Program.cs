using System;
using System.Threading;

namespace _1342._将数字变成_0_的操作次数
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/number-of-steps-to-reduce-a-number-to-zero/

            Console.WriteLine(NumberOfSteps(14));
            Console.WriteLine(NumberOfSteps(8));
            Console.WriteLine(NumberOfSteps(123));
        }

        #region 方法1: 模拟
        //static int NumberOfSteps(int num)
        //{
        //    int rtn = 0;
        //    while (num != 0)
        //    {
        //        if (num % 2 == 0)
        //        {
        //            // 偶数
        //            num /= 2;
        //        }
        //        else
        //        {
        //            // 奇数
        //            num--;
        //        }
        //        rtn++;
        //    }

        //    return rtn;
        //}
        #endregion

        #region 方法2: 模拟优化: 用二进制运算
        static int NumberOfSteps(int num)
        {
            int rtn = 0;
            while (num != 0)
            {
                // 一个数 与上 1 等于 1 说明是 奇数，否则是 偶数
                // -1 等价于 二进制运算 num & -2
                // 除以2 等价于二进制运算右移1位 >> 1
                // 参考: https://blog.csdn.net/qq_36748278/article/details/54577930
                // https://www.cnblogs.com/mybk/p/6803237.html
                num = (num & 1) == 1 ? num & -2 : num >> 1;
                rtn++;
            }

            return rtn;
        }
        #endregion

    }
}
