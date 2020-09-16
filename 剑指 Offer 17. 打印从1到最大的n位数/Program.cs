using System;

namespace 剑指_Offer_17._打印从1到最大的n位数
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] result = PrintNumbers(1);
            int[] result = PrintNumbers(3);




            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        #region 方法1
        /// <summary>
        /// 时间复杂度: O(10^n), 空间复杂度: O(1), 列表作为返回结果，不计入额外空间
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        //static int[] PrintNumbers(int n)
        //{
        //    int end = 1;
        //    for (int i = 0; i < n; i++)
        //    {
        //        end *= 10;
        //    }
        //    end -= 1;
        //    int[] result = new int[end];
        //    for (int i = 1; i <= end; i++)
        //    {
        //        result[i - 1] = i;
        //    }

        //    return result;
        //} 
        #endregion

        #region 方法2: 大数打印解法
        static int[] res;
        static int nine = 0, count = 0, start, n;
        static char[] num, loop = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static int[] PrintNumbers(int n)
        {
            n = n;
            res = new int[(int)Math.Pow(10, n) - 1];
            num = new char[n];
            start = n - 1;
            Dfs(0);
            return res;
        }

        static void Dfs(int x)
        {
            if (x == n)
            {
                string s = num.ToString().Substring(start);
                if (s != "0")
                {
                    res[count++] = int.Parse(s);
                }
                if (n - start == nine)
                {
                    start--;
                }
                return;
            }
            foreach (char ch in loop)
            {
                if (ch == '9')
                {
                    nine++;
                }
                num[x] = ch;
                Dfs(x + 1);
            }
            nine--;
        }
        #endregion
    }
}
