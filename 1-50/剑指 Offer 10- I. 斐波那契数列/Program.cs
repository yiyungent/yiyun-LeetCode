using System;
using System.Collections.Generic;

namespace 剑指_Offer_10__I._斐波那契数列
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(2));
            Console.WriteLine(Fib(5));

            Console.ReadLine();
        }

        #region 方法一: 递归: 太多重复操作，效率低 导致 超出时间限制
        //static int Fib(int n)
        //{
        //    if (n == 0)
        //    {
        //        return 0;
        //    }
        //    if (n == 1)
        //    {
        //        return 1;
        //    }
        //    return Fib(n - 1) + Fib(n - 2);
        //}
        #endregion

        #region 方法二: 记忆化递归法
        //static int Fib(int n)
        //{
        //    Dictionary<int, int> dic = new Dictionary<int, int>();
        //    return FibExcur(n, dic);
        //}

        //static int FibExcur(int n, Dictionary<int, int> dic)
        //{
        //    if (n == 0)
        //    {
        //        return 0;
        //    }
        //    if (n == 1)
        //    {
        //        return 1;
        //    }
        //    // 记忆已经计算过的项，避免重复运算
        //    if (dic.ContainsKey(n))
        //    {
        //        return dic[n];
        //    }

        //    int result = Fib(n - 1) + Fib(n - 2);
        //    dic.Add(n, result);
        //    return result;
        //}
        #endregion

        #region 方法三:循环
        static int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            int[] array = new int[n + 1];
            array[0] = 0;
            array[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                // f(2) = f(1) + f(0)
                // f(3) = f(2) + f(1)
                // f(4) = f(3) + f(2)
                // f(5) = f(4) + f(3)
                array[i] = array[i - 1] + array[i - 2];

                array[i] %= 1000000007;
            }

            return array[n];
        }
        #endregion
    }
}
