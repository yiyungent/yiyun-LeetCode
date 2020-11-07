using System;

namespace _1588._所有奇数长度子数组的和
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/sum-of-all-odd-length-subarrays/

            Console.WriteLine(SumOddLengthSubarrays(new int[] { 1, 4, 2, 5, 3 }));




        }

        #region 方法1
        /// <summary>
        /// TODO: 没懂
        /// https://leetcode-cn.com/problems/sum-of-all-odd-length-subarrays/solution/onshi-jian-fu-za-du-o1shi-jian-fu-za-du-by-crj1998/
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int SumOddLengthSubarrays(int[] arr)
        {
            int len = arr.Length, res = 0;
            for (int i = 0; i < len; i++)
            {
                int LeftOdd = (i + 1) / 2, LeftEven = i / 2 + 1;
                int RightOdd = (len - i) / 2, RightEven = (len - 1 - i) / 2 + 1;
                res += arr[i] * (LeftOdd * RightOdd + LeftEven * RightEven);
            }
            return res;
        }
        #endregion


    }
}
