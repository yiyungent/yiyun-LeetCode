using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace 前K个高频元素
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int k = 2;
            int[] result = TopKFrequent(nums, k);

            foreach (int num in result)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }

        #region 方法一: 桶排序
        static int[] TopKFrequent(int[] nums, int k)
        {
            List<int> rtn = new List<int>();
            // 建立出现次数数组
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                // key: 数字 value: 此数出现次数
                if (dic.ContainsKey(num))
                {
                    dic[num] = dic[num] + 1;
                }
                else
                {
                    dic.Add(num, 1);
                }
            }
            // 桶排序
            // 将出现次数（频率）作为下标
            List<int>[] list = new List<int>[nums.Length + 1];
            // 遍历所有(不同)数字
            foreach (var key in dic.Keys)
            {
                // 获取出现次数作为下标
                int i = dic[key];
                if (list[i] == null)
                {
                    list[i] = new List<int>();
                }
                // i下标为出现次数, 值为 出现此次数的数字列表
                list[i].Add(key);
            }

            // 倒序遍历数组获取出现次数顺序从大到小的排列
            for (int i = list.Length - 1; i >= 0 && rtn.Count < k; i--)
            {
                if (list[i] == null) continue;
                rtn.AddRange(list[i]);
            }

            return rtn.ToArray();
        }
        #endregion
    }
}
