using System;

namespace _1266._访问所有点的最小时间
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/minimum-time-visiting-all-points/
            int[][] points = {
                new int[] { 1, 1 },
                new int[] { 3, 4 },
                new int[] { -1, 0 },
            };
            Console.WriteLine(MinTimeToVisitAllPoints(points));
        }

        #region 方法1: 切比雪夫距离
        /// <summary>
        /// TODO: 没懂
        /// 时间复杂度：O(N)，其中 N 是数组的长度
        /// 空间复杂度：O(1)
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        static int MinTimeToVisitAllPoints(int[][] points)
        {
            int x0 = points[0][0], x1 = points[0][1];
            int ans = 0;
            for (int i = 1; i < points.Length; ++i)
            {
                int y0 = points[i][0], y1 = points[i][1];
                ans += Math.Max(Math.Abs(x0 - y0), Math.Abs(x1 - y1));
                x0 = y0;
                x1 = y1;
            }
            return ans;
        }
        #endregion

    }
}
