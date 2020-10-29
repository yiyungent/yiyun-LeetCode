using System;

namespace _1281._整数的各位积和之差
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
            Console.WriteLine(SubtractProductAndSum(234));
            Console.WriteLine(SubtractProductAndSum(4421));

        }

        #region 方法1
        /// <summary>
        /// 时间复杂度: O(log n)
        /// 空间复杂度: O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int SubtractProductAndSum(int n)
        {
            int mul = 1;
            int sum = 0;
            int temp = n;
            while (n != 0)
            {
                // 取个位
                temp = n % 10;

                mul *= temp;
                sum += temp;

                // 右移位
                n /= 10;
            }

            return mul - sum;
        }
        #endregion


    }
}
