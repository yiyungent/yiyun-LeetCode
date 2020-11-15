using System;

namespace _832._翻转图像
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[][] {
                new int[]{ 1, 1, 0 },
                new int[]{ 1, 0, 1 },
                new int[]{ 0, 0, 0},
            };

            int[][] result = FlipAndInvertImage(arr);

            foreach (var item in result)
            {
                foreach (var i in item)
                {
                    Console.Write(i + ", ");
                }
            }


            Console.ReadLine();
        }

        #region 方法1
        /// <summary>
        /// 时间复杂度：O(M*N)，其中 M 和 N 分别为数组 A 的行数和列数
        /// 空间复杂度：O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        static int[][] FlipAndInvertImage(int[][] A)
        {
            int c = A[0].Length;
            foreach (int[] row in A)
            {
                for (int i = 0; i < (c + 1) / 2; ++i)
                {
                    int tmp = row[i] ^ 1;
                    row[i] = row[c - 1 - i] ^ 1;
                    row[c - 1 - i] = tmp;
                }
            }

            return A;
        }
        #endregion

    }
}
