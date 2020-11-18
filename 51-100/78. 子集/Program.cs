using System;
using System.Collections.Generic;

namespace _78._子集
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/subsets/
            
            var sol = new Solution();
            var result = sol.Subsets(new int[] { 1, 2, 3 });
            foreach (var item in result)
            {
                Console.WriteLine(string.Join(", ", item));
            }

            Console.ReadLine();
        }





    }

    public class Solution
    {
        #region 方法1
        /// <summary>
        /// 注意：_ans 没清除，一定不能是 static 变量，否则后续算法执行会受影响，从而导致错误结果
        /// </summary>
        List<int> _t = new List<int>();
        IList<IList<int>> _ans = new List<IList<int>>();

        /// <summary>
        /// 时间复杂度: O(n* 2^n) 一共 2^n 个状态，每种状态需 O(n) 的时间来构造子集
        /// 空间复杂度: O(n)  构造子集使用的临时数组 t 的空间代价
        /// TODO: 没懂
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> Subsets(int[] nums)
        {
            int n = nums.Length;
            for (int mask = 0; mask < (1 << n); mask++)
            {
                _t.Clear();
                for (int i = 0; i < n; i++)
                {
                    if ((mask & (1 << i)) != 0)
                    {
                        _t.Add(nums[i]);
                    }
                }
                var temp = new List<int>();
                temp.AddRange(_t);
                _ans.Add(temp);
            }

            return _ans;
        }
        #endregion
    }
}
