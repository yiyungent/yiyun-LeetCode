using System;
using System.IO.MemoryMappedFiles;

namespace _125._验证回文串
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        }

        #region 方法一: 对撞双指针+原地
        static bool IsPalindrome(string s)
        {
            int n = s.Length;
            int left = 0, right = n - 1;
            while (left < right)
            {
                // 左指针 -> ++ 直到指向 满足数字或字母
                while (left < right && !IsAlnum(s[left]))
                {
                    ++left;
                }
                // 右指针 <- -- 直到指向 满足数字或字母
                while (left < right && !IsAlnum(s[right]))
                {
                    --right;
                }
                if (left < right)
                {
                    if (s[left].ToString().ToLower() != s[right].ToString().ToLower())
                    {
                        // 此时，不相同 则一定非回文串
                        return false;
                    }
                    ++left;
                    --right;
                }
            }

            return true;
        }
        #endregion

        #region 是数字或字母
        static bool IsAlnum(char ch)
        {
            return (ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z') || (ch >= '0' && ch <= '9');
        }
        #endregion

    }
}
