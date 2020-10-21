using System;

namespace 剑指_Offer_62._圆圈中最后剩下的数字
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/yuan-quan-zhong-zui-hou-sheng-xia-de-shu-zi-lcof/

            Console.WriteLine(LastRemaining(5, 3));
            Console.WriteLine(LastRemaining(10, 17));
            // TODO: 约瑟夫环问题: 不懂
        }

        #region 方法1: 数学+递归
        ///// <summary>
        ///// 递归计算 f(n, m), f(n - 1, m), f(n - 2, m), ... 直到递归的终点 f(1, m)。当序列长度为 1 时，一定会留下唯一的那个元素，它的编号为 0
        ///// </summary>
        ///// <param name="n"></param>
        ///// <param name="m"></param>
        ///// <returns></returns>
        //static int F(int n, int m)
        //{
        //    if (n == 1)
        //    {
        //        return 0;
        //    }
        //    int x = F(n - 1, m);
        //    return (m + x) % n;
        //}

        //static int LastRemaining(int n, int m)
        //{
        //    return F(n, m);
        //}
        #endregion

        #region 方法2: 数学+迭代
        static int LastRemaining(int n, int m)
        {
            // 最终剩下的数字的初始位置
            int pos = 0;
            for (int i = 2; i <= n; i++)
            {
                // 每次循环右移
                pos = (pos + m) % i;
            }
            return pos;
        }
        #endregion
    }
}
