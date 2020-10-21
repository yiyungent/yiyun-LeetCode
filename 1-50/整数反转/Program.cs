using System;

namespace 整数反转
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 123456789;

            int result = Reverse(num);

            Console.ReadLine();
        }

        static int Reverse(int num)
        {
            int rev = 0;
            while (num != 0)
            {
                // 取个位弹出
                int pop = num % 10;
                // 降位: 百位变十位
                num = num / 10;
                // 防止溢出
                if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && pop > 7)) return 0;
                if (rev < int.MinValue / 10 || (rev == int.MinValue / 10 && pop < -8)) return 0;

                rev = rev * 10 + pop;
            }

            return rev;
        }
    }
}
