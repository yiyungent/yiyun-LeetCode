using System;

namespace _70._爬楼梯
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/climbing-stairs/

            Console.WriteLine(ClimbStairs(2));
            Console.WriteLine(ClimbStairs(3));

        }

        #region 方法1: 递归
        /// <summary>
        /// 有重复运算，效率低 -> 超出时间限制
        /// eg: f(4) = f(3) + f(2), f(5) = f(4) + f(3)  重复计算 f(3)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        //static int ClimbStairs(int n)
        //{
        //    if (n == 0)
        //    {
        //        return 1;
        //    }
        //    if (n == 1)
        //    {
        //        return 1;
        //    }

        //    // f(n) = f(n-1) + f(n-2)
        //    return ClimbStairs(n - 1) + ClimbStairs(n - 2);
        //}
        #endregion

        #region 方法2: 循环
        //static int ClimbStairs(int n)
        //{
        //    if (n <= 1)
        //    {
        //        return 1;
        //    }
        //    int[] arr = new int[n + 1];
        //    arr[0] = 1;
        //    arr[1] = 1;
        //    for (int i = 2; i < arr.Length; i++)
        //    {
        //        arr[i] = arr[i - 1] + arr[i - 2];
        //    }
        //    return arr[n];
        //}
        #endregion

        #region 方法3: 循环 压缩优化
        /// <summary>
        /// dp[i] 只与 dp[i - 1] 和 dp[i - 2] 有关，没有必要存储所有计算过的 dp 项。用两个临时变量去存这两个状态就好
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int ClimbStairs(int n)
        {
            int prev = 1, cur = 1;
            int temp;
            for (int i = 2; i < n + 1; i++)
            {
                temp = cur; // 暂存上一次的 cur
                cur = prev + cur; // 当前的 cur = 上上次cur + 上一次cur
                prev = temp; // prev 更新为 上一次 cur
            }

            return cur;
        }
        #endregion

    }
}
