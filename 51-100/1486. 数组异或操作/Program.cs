using System;

namespace _1486._数组异或操作
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/xor-operation-in-an-array/
            int n = 5;
            int start = 0;
            Console.WriteLine(XorOperation(n, start));



        }

        #region 方法1
        /// <summary>
        /// 时间复杂度：O(n)
        /// 空间复杂度：O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        static int XorOperation(int n, int start)
        {
            // 返回 nums 中所有元素按位异或（XOR）后得到的结果
            int rtn = 0;
            for (int i = 0; i < n; i++)
            {
                // ^ 异或: 一True一False -> True，其它均 False
                rtn ^= (start + 2 * i);
            }
            return rtn;
        }
        #endregion

    }
}
