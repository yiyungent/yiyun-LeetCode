using System;

namespace _66._加一
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/plus-one/

            Console.WriteLine(string.Join(",", PlusOne(new int[] { 1, 2, 3 })));
            Console.WriteLine(string.Join(",", PlusOne(new int[] { 4, 3, 2, 1 })));
            Console.WriteLine(string.Join(",", PlusOne(new int[] { 9 })));

        }

        #region 方法1
        static int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i]++;
                digits[i] = digits[i] % 10;
                if (digits[i] != 0)
                {
                    // 当此为不为0说明，不再需要进位，直接返回
                    return digits;
                }
            }
            // 没有return ,说明一直需要进位，所以只能是 999 情况
            // 999 + 1 = 1000
            digits = new int[digits.Length + 1];
            digits[0] = 1;
            return digits;
        }
        #endregion




    }
}
