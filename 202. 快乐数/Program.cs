using System;
using System.Collections.Generic;

namespace _202._快乐数
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/happy-number/

            Console.WriteLine(IsHappy(19));
        }



        #region 方法1: 用 HashSet 检测循环
        /// <summary>
        /// 19 -> 1^2 + 9^2 = 82
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int GetNext(int n)
        {
            int totalSum = 0;
            // 余数
            int d = 0;
            while (n > 0)
            {
                // 取个位
                d = n % 10;
                // 去掉个位
                n /= 10;
                // 个位 平方和
                totalSum += d * d;
            }
            return totalSum;
        }

        /// <summary>
        /// 代码中不必实现第三种可能: 3.值会越来越大，最后接近无穷大
        /// eg: 三位数: 999 最大Next = 9^2 + 9^9 + 9^9 = 243
        /// 所以我们知道，最坏的情况下，算法可能会在 243 以下的所有数字上循环，然后回到它已经到过的一个循环或者回到 1。但它不会无限期地进行下去，所以我们排除第三种选择
        /// 
        /// 时间复杂度: O(243⋅3+logn+loglogn+logloglogn)... = O(logn)
        /// 空间复杂度：O(logn)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static bool IsHappy(int n)
        {
            // 我们使用 HashSet 而不是向量、列表或数组的原因是因为我们反复检查其中是否存在某数字。检查数字是否在哈希集中需要 O(1) 的时间，而对于其他数据结构，则需要 O(n)的时间
            // 用 HashSet 来存已经出现的数, 如果重复出现，则说明出现循环。处于循环，则不是一个快乐数
            HashSet<int> seen = new HashSet<int>();
            while (n != 1 && !seen.Contains(n))
            {
                seen.Add(n);
                n = GetNext(n);
            }

            return n == 1;
        }
        #endregion

    }
}
