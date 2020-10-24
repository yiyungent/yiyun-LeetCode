using System;

namespace _1108._IP_地址无效化
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode-cn.com/problems/defanging-an-ip-address/
            string address = "1.1.1.1";

            Console.WriteLine(DefangIPaddr(address));
        }

        #region 方法1
        static string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
        #endregion

    }
}
