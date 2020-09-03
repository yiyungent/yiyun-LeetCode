using System;
using System.Net;
using System.Text;

namespace 回文数
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 12321;

            Console.WriteLine(IsPalindrome1(num));
            Console.WriteLine(IsPalindrome2(num));
        }

        static bool IsPalindrome1(int x)
        {
            string str = x.ToString();
            bool rtn = false;
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            if (sb.ToString() == str)
            {
                rtn = true;
            }

            return rtn;
        }

        static bool IsPalindrome2(int x)
        {
            // 负数及个位为0的不是回文数
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            // 反转一半
            int revertedNumber = 0;
            // 当 x <= revertedNumber 时，说明已经反转了一半
            // 反转从低位开始
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            // x:12     revertedNumber: 123
            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}
