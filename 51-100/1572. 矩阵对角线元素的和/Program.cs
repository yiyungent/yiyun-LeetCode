using System;

namespace _1572._矩阵对角线元素的和
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mat = new int[3][] {
                new int[] { 1,2,3 },
                new int[] { 4,5,6 },
                new int[] { 7, 8, 9 }
            };

            Console.WriteLine(DiagonalSum(mat));
        }

        #region 方法1: 遍历矩阵
        static int DiagonalSum(int[][] mat)
        {
            int rtn = 0;
            // 主对角元素 行号=列号
            // 次对角元素 i + j == n - 1
            // 矩阵是正方形矩阵，只有当矩阵行数/列数是奇数时，才存在重复计算中间元素值的情况
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat.Length; j++)
                {
                    if (i == j || i + j == mat.Length - 1)
                    {
                        rtn += mat[i][j];
                    }
                }
            }
            // 不需要考虑，因为一个元素只会被遍历到一次
            //if ((mat.Length & 1) == 1)
            //{
            //    // 奇数
            //    // 中间元素 索引
            //    int temp = mat.Length / 2;
            //    rtn -= mat[temp][temp];
            //}

            return rtn;
        }
        #endregion

    }
}
