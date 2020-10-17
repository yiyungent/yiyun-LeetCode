using System;
using System.Collections;
using System.Collections.Generic;

namespace _412._Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            Console.WriteLine(string.Join(", ", FizzBuzz(n)));
        }

        #region 方法1: 字符串连接
        /// <summary>
        /// 时间复杂度: O(n)
        /// 空间复杂度: O(1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        //static IList<string> FizzBuzz(int n)
        //{
        //    IList<string> rtn = new List<string>();
        //    for (int i = 1; i <= n; i++)
        //    {
        //        string temp = "";
        //        if (i % 3 == 0)
        //        {
        //            temp = "Fizz";
        //        }
        //        if (i % 5 == 0)
        //        {
        //            temp += "Buzz";
        //        }
        //        if (temp == "")
        //        {
        //            temp = i.ToString();
        //        }
        //        rtn.Add(temp);
        //    }

        //    return rtn;
        //}
        #endregion

        #region 方法2: 字典
        /// <summary>
        /// 时间复杂度: O(n)
        /// 空间复杂度: O(1)
        /// 优点: 更灵活
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static IList<string> FizzBuzz(int n)
        {
            IList<string> rtn = new List<string>();
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                { 3, "Fizz" },
                { 5, "Buzz" },
            };
            for (int i = 1; i <= n; i++)
            {
                string temp = "";
                foreach (var item in dic.Keys)
                {
                    if (i % item == 0)
                    {
                        temp += dic[item];
                    }
                }
                if (temp == "")
                {
                    temp = i.ToString();
                }
                rtn.Add(temp);
            }

            return rtn;
        }
        #endregion


    }
}
