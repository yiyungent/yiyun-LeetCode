using System;
using System.Collections;
using System.Collections.Generic;

namespace _1431._拥有最多糖果的孩子
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/kids-with-the-greatest-number-of-candies/
            int[] candies = { 2, 3, 5, 1, 3 };
            int extraCandies = 3;
            var result = KidsWithCandies(candies, extraCandies);
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }

        }


        #region 方法1
        /// <summary>
        /// 自己: 时间复杂度: O(2n)
        /// 空间复杂度: O(n)
        /// 
        /// 不懂为什么，循环2次算 O(n)
        /// 最后返回结果用 IList<bool> rtn ，为什么也算 O(1)
        /// 官方答案: 
        /// 时间复杂度: O(n)
        /// 空间复杂度: O(1) 只用了常数个变量作为辅助空间，与 nn 的规模无关
        /// </summary>
        /// <param name="candies"></param>
        /// <param name="extraCandies"></param>
        /// <returns></returns>
        static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            // 只要当前指向孩子拥有的糖果数量 + extraCandies >= Max(candies), 那么他就将成为拥有糖果数最多的孩子, 否者不是
            // 首先找 未加额外糖果时，每个孩子拥有的最多糖果的数量
            int max = candies[0];
            for (int i = 1; i < candies.Length; i++)
            {
                //if (candies[i] > max)
                //{
                //    max = candies[i];
                //}
                max = Math.Max(candies[i], max);
            }
            IList<bool> rtn = new List<bool>();
            for (int i = 0; i < candies.Length; i++)
            {
                //if (candies[i] + extraCandies >= max)
                //{
                //    rtn.Add(true);
                //}
                //else
                //{
                //    rtn.Add(false);
                //}
                rtn.Add(candies[i] + extraCandies >= max);
            }
            return rtn;
        }
        #endregion

    }
}
