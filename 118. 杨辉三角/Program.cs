using System;
using System.Collections;
using System.Collections.Generic;

namespace _118._杨辉三角
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/pascals-triangle/
            var result = Generate(5);
            foreach (var row in result)
            {
                foreach (var item in row)
                {
                    Console.Write(item + " ");
                }
            }


        }

        #region 方法1: 动态规划
        static IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> rtn = new List<IList<int>>();
            if (numRows == 0)
            {
                return rtn;
            }
            // 第一行 总是 1
            rtn.Add(new List<int>());
            rtn[0].Add(1);

            // 从第二行开始
            for (int i = 1; i < numRows; i++)
            {
                List<int> row = new List<int>();
                IList<int> prevRow = rtn[i - 1];
                // 行首元素 一定是 1
                row.Add(1);

                // 第 i 行 有 i 个元素 -> 索引 为 i 行 有 i + 1 个元素
                // 注意: j < i   不是 j < i + 1 , 因为行尾元素 额外 赋值 1
                for (int j = 1; j < i; j++)
                {
                    // 从第二个元素开始
                    // 在杨辉三角中，每个数是它左上方和右上方的数的和。
                    row.Add(prevRow[j - 1] + prevRow[j]);
                }
                // 行尾元素一定是 1
                row.Add(1);
                // 添加此行
                rtn.Add(row);
            }

            return rtn;
        }
        #endregion


    }
}
