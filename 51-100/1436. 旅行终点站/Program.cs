using System;
using System.Collections.Generic;

namespace _1436._旅行终点站
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/destination-city/



        }


        #region 方法1: 字典
        static string DestCity(IList<IList<string>> paths)
        {
            // key: 起点 value: 终点
            IDictionary<string, string> dic = new Dictionary<string, string>();
            foreach (var path in paths)
            {
                dic.Add(path[0], path[1]);
            }
            // paths[0][0] 最开始 起点
            string city = paths[0][0];
            while (dic.ContainsKey(city))
            {
                // 更新起点(当前位置)
                city = dic[city];
            }
            // 退出循环条件为: 此位置 没有目标终点

            return city;
        }
        #endregion


    }
}
