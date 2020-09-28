using System;

namespace 剑指_Offer_21._调整数组顺序使奇数位于偶数前面
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            // 数组是引用类型, 原地交换, 无需重新赋值接收
            Exchange(nums);

            foreach (var item in nums)
            {
                Console.Write(item + " ");
            }
        }

        #region 方法1: 对撞双指针
        /// <summary>
        /// 时间复杂度: O(n): n为数组长度, 双指针left, right共同遍历完整个数组
        /// 空间复杂度: O(1): 双指针left,right使用常数大小的额外空间
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        static int[] Exchange(int[] nums)
        {
            // 要求最后结果 奇数在前，偶数在后
            // left从首向右移动 找偶数, right从尾向左移动 找奇数
            int left = 0, right = nums.Length - 1;
            // 指针相遇即遍历完数组，退出循环
            while (left < right)
            {
                // &位运算: 这里相当于 nums[left] % 2 != 0
                if ((nums[left] & 1) != 0)
                {
                    // 是奇数 跳过
                    left++;
                    continue;
                }
                // &位运算: 这里相当于 nums[right] % 2 != 1
                if ((nums[right] & 1) != 1)
                {
                    // 是偶数 跳过
                    right--;
                    continue;
                }
                // 当 left 指向偶数 且 right 指向 奇数 时，交换位置
                nums[left] = nums[left] + nums[right];
                nums[right] = nums[left] - nums[right];
                nums[left] = nums[left] - nums[right];
                // 交换完毕, 均向前一步
                left++;
                right--;
            }

            return nums;
        }
        #endregion
    }
}
