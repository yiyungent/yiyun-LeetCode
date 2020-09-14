using System;

namespace 剑指_Offer_04._二维数组中的查找
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[5][] {
                new int[] { 1, 4, 7, 11, 15 },
                new int[]{ 2, 5, 8, 12, 19 },
                new int[]{ 3, 6, 9, 16, 22 },
                new int[]{ 10, 13, 14, 17, 24 },
                new int[] { 18, 21, 23, 26, 30 }
            };

            bool result = FindNumberIn2DArray(matrix, 5);


            Console.WriteLine(result);


            Console.ReadLine();
        }

        #region 方法1:暴力遍历
        //static bool FindNumberIn2DArray(int[][] matrix, int target)
        //{
        //    if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
        //    {
        //        return false;
        //    }
        //    int row = matrix.Length, col = matrix[0].Length;
        //    for (int i = 0; i < row; i++)
        //    {
        //        for (int j = 0; j < col; j++)
        //        {
        //            if (matrix[i][j] == target)
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}
        #endregion

        #region 方法二: 线性查找
        static bool FindNumberIn2DArray(int[][] matrix, int target)
        {
            // 从右上角开始查找
            // 列往左边移: col--
            // 行往下边移动: row++
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            {
                return false;
            }

            int rows = matrix.Length, cols = matrix[0].Length;
            // 起始点: 右上角点
            int row = 0, col = cols - 1;
            while (row < rows && col >= 0)
            {
                int num = matrix[row][col];
                if (num == target)
                {
                    return true;
                }
                else if (num > target)
                {
                    col--;
                }
                else
                {
                    row++;
                }
            }

            return false;
        }
        #endregion
    }
}
