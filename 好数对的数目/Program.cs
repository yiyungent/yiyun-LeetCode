using System;
using System.Collections.Generic;

namespace 好数对的数目
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 1, 1, 3 };

            int ans = NumIdenticalPairs(nums);

            Console.WriteLine(ans);

            Console.ReadLine();
        }

        #region 方法一:暴力统计
        /// <summary>
        /// 枚举所有
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        //static int NumIdenticalPairs(int[] nums)
        //{
        //    int ans = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        for (int j = i + 1; j < nums.Length; j++)
        //        {
        //            if (nums[i] == nums[j])
        //            {
        //                ans++;
        //            }
        //        }
        //    }
        //    return ans;
        //}
        #endregion

        #region 方法二:组合计数
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        static int NumIdenticalPairs(int[] nums)
        {
            // key: 数字 value: 出现次数
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dic.ContainsKey(num))
                {
                    dic[num] = dic[num] + 1;
                }
                else
                {
                    dic.Add(num, 1);
                }
            }

            // 组合: 
            //输入：nums = [1, 1, 1, 1]
            //输出：6
            //解释：数组中的每组数字都是好数对
            // 从4个中选2个组合
            // C(4,2)   =   A(4,2) / 2!  =  4*(4-1)/2  =   6



            // 假设数字 k 在序列中出现的次数为 v，那么满足题目中所说的 nums[i]==nums[j]=k (i<j) 的(i,j)的数量就是 v*(v-1)/2,  即k这个数字对答案的贡献就是 v*(v-1)/2
            int ans = 0;
            foreach (var val in dic.Values)
            {
                ans += val * (val - 1) / 2;
            }

            return ans;
        }
        #endregion
    }
}
