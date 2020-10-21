using System;

namespace 移除元素
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 2, 3 };

            int len = RemoveElement(nums, 3);

            for (int i = 0; i < len; i++)
            {
                Console.Write(nums[i] + " ");
            }

            Console.ReadLine();
        }

        #region 双指针-覆盖:适合移除元素较多: 时间复杂度:O(n), 空间复杂度:O(1), 最极端情况所有元素都需要移除，只需遍历一次即可结束
        // 将要保留的元素往前面覆盖
        //public static int RemoveElement(int[] nums, int val)
        //{
        //    // 双指针
        //    // 慢指针: 指向存最后需保留元素(不等于val)
        //    int i = 0;
        //    int len = nums.Length;
        //    // 快指针: 遍历数组
        //    for (int j = 0; j < len; j++)
        //    {
        //        // 不等于val的元素往前面覆盖
        //        if (nums[j] != val)
        //        {
        //            // 覆盖
        //            nums[i] = nums[j];
        //            // 这里已经被覆盖过，存有需保留的值，不再覆盖，i++
        //            i++;
        //        }
        //    }
        //    return i;
        //} 
        #endregion

        #region 交换: 适合移除元素较少: 时间复杂度:O(n), 空间复杂度:O(1), 最极端情况所有元素都不需要移除，只需遍历一次即可结束
        /// <summary>
        /// 将要移除的元素交换到最后面(非移除元素交换到前面)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            int len = nums.Length;
            while (i < len)
            {
                if (nums[i] == val)
                {
                    // 移除元素交换
                    // [len - 1]: 要保留的数组的最后一位
                    // 后面的赋值给前面
                    // nums[len - 1]可能是要移除的元素，但不用担心，因为下一次迭代依然会检查此元素
                    nums[i] = nums[len - 1];
                    // 减小要保留的数组长度
                    len--;
                }
                else
                {
                    i++;
                }
            }

            return i;
        }
        #endregion

    }
}
