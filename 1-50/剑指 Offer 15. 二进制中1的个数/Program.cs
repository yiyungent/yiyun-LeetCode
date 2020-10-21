using System;

namespace 剑指_Offer_15._二进制中1的个数
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/er-jin-zhi-zhong-1de-ge-shu-lcof/

            Console.WriteLine(HammingWeight(9));
            Console.WriteLine(HammingWeight(26));
            Console.WriteLine(HammingWeight(10));
        }

        #region 方法1
        //static int HammingWeight(uint n)
        //{
        //    // yu 余数
        //    uint yu = n % 2;
        //    // div 除后 整数
        //    uint div = n / 2;
        //    // 1 的个数
        //    uint count = yu;
        //    while (div > 0)
        //    {
        //        yu = div % 2;
        //        div /= 2;
        //        count += yu;
        //    }
        //    // 注意: 最后 /2 时, 如果无法整除，需 +剩下的 1

        //    return (int)count;
        //}
        #endregion

        #region 方法2:逐位判断
        /// <summary>
        /// 时间复杂度: O(log_2 n) 此算法循环内部仅有移位，与，加等基本运算，占用O(1);逐位判断需循环log_2 n 次, 其中 log_2 n 代表数字n 最高位1的所在位数（例如: log_2 4=2, log_2 16=4）
        /// 空间复杂度: O(1) 变量 count 使用常数大小额外空间
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int HammingWeight(uint n)
        {
            uint count = 0;
            while (n != 0)
            {
                // & 与运算
                // 10001 & 1 = 1 说明 10001 最后一位是 1
                // 10010 & 1 = 0 说明 10010 最后一位是 0
                count += n & 1;
                // 右移1位
                // eg: 10001 右移1位 1000
                //n = n >> 1;
                n >>= 1;
            }

            return (int)count;
        }
        #endregion
    }
}
