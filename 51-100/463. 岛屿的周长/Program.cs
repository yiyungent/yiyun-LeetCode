using System;

namespace _463._岛屿的周长
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/island-perimeter/
            int[][] grid = new int[4][] {
                new int[4] { 0, 1, 0, 0 },
                new int[4] { 1, 1, 1, 0 },
                new int[4] { 0, 1, 0, 0 },
                new int[4] { 1, 1, 0, 0 },
            };


            Console.WriteLine(IslandPerimeter(grid));
        }

        #region 方法一: 迭代
        static int[] dx = { 0, 1, 0, -1 };
        static int[] dy = { 1, 0, -1, 0 };
        /// <summary>
        /// 时间复杂度：O(nm)   其中 n 为网格的高度，m 为网格的宽度
        /// 空间复杂度：O(1)
        /// TODO: 没懂
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        static int IslandPerimeter(int[][] grid)
        {
            int n = grid.Length, m = grid[0].Length;
            int ans = 0;
            // 遍历每个陆地格子，看其四个方向是否为边界或者水域，如果是，将这条边的贡献（即 1）加入答案 ans 中
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        int cnt = 0;
                        for (int k = 0; k < 4; k++)
                        {
                            int tx = i + dx[k];
                            int ty = j + dy[k];
                            if (tx < 0 || tx >= n || ty < 0 || ty >= m || grid[tx][ty] == 0)
                            {
                                cnt++;
                            }
                        }

                        ans += cnt;
                    }
                }
            }

            return ans;
        }
        #endregion

    }
}
