using System;
using System.IO.Pipes;

namespace _867._转置矩阵
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] result = Transpose(new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            });

            int[][] result2 = Transpose(new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 }
            });


            Console.ReadLine();
        }



        #region 方法1
        /// <summary>
        /// 复制,交换 
        /// R x C 矩阵 -> C x R 矩阵
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        static int[][] Transpose(int[][] A)
        {
            int R = A.Length, C = A[0].Length;
            int[][] rtn = new int[C][];
            for (int r = 0; r < R; r++)
            {
                for (int c = 0; c < C; c++)
                {
                    if (rtn[c] == null)
                    {
                        rtn[c] = new int[R];
                    }
                    rtn[c][r] = A[r][c];
                }
            }
            return rtn;
        }
        #endregion





    }
}
