using System;

namespace 剑指Offer10_II.青蛙跳台阶
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumWays(2));
            Console.WriteLine(NumWays(7));
            Console.WriteLine(NumWays(0));
        }

        #region 方法一: 递归:效率差，太多重复操作 导致 超出时间限制
        /// <summary>
        /// 当n等于1的时候，只需要跳一次即可，只有一种跳法，记f(1)=1
        /// 
        /// 当n等于2的时候，可以先跳一级再跳一级，或者直接跳二级，共有2种跳法，记f(2)=2
        /// 
        /// 当n等于3的时候，他可以从一级台阶上跳两步上来，也可以从二级台阶上跳一步上来，所以总共有f(3)=f(2)+f(1)
        /// 
        /// 同理当等于n的时候，总共有f(n)=f(n-1)+f(n-2)(这里n>2)种跳法
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        //static int NumWays(int n)
        //{
        //    if (n <= 1)
        //    {
        //        return 1;
        //    }
        //    if (n < 3)
        //    {
        //        return n;
        //    }
        //    return NumWays(n - 1) + NumWays(n - 2);
        //}
        #endregion


        #region 方法二：循环
        static int NumWays(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            int[] array = new int[n + 1];
            array[1] = 1;
            array[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
                // 答案需要取模 1e9+7（1000000007），如计算初始结果为：1000000008，请返回 1。
                array[i] %= 1000000007;
            }

            return array[n];
        }
        #endregion
    }
}
