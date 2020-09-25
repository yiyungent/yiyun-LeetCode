using System;

namespace 剑指_Offer_39._数组中出现次数超过一半的数字
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MajorityElement(new int[] { 1, 2, 3, 2, 2, 2, 5, 4, 2 }));
        }

        #region 摩尔投票法
        /// <summary>
        /// TODO: 没懂
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        static int MajorityElement(int[] nums)
        {
            int x = 0, votes = 0;
            foreach (var num in nums)
            {
                if (votes == 0)
                {
                    x = num;
                }
                votes += num == x ? 1 : -1;
            }
            // 由于题目明确给定 给定的数组总是存在多数元素 ，因此本题不用考虑 数组中不存在众数 的情况

            return x;
        }
        #endregion
    }
}
