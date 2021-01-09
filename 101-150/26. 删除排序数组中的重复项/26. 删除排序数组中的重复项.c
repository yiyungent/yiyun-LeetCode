// 26. 删除排序数组中的重复项.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

// 方法1：双指针：快慢指针
int removeDuplicates(int* nums, int numsSize) {
    if (numsSize < 2) {
        return numsSize;
    }

    // i 指向当前正比较的两个相邻的两个元素
    // j 指向无重复的最后一个元素
    int i = 1, j = 1;
    while (i + 1 <= numsSize) {
        // 注意：数组最大下标值 + 1 = 数组长度，还有个 -1 （<=）是因为防止下面的-1越界
        if (nums[i - 1] != nums[i]) {
            nums[j] = nums[i];
            j++;
        }
        i++;
    }

    return j;
}

int main()
{
    std::cout << "Hello World!\n";
}


// https://leetcode-cn.com/problems/remove-duplicates-from-sorted-array/


