from typing import List

class Solution:

    # 方法1: 双指针
    def removeDuplicates(self, nums: List[int]) -> int:
        j, count = 1, 1
        for i in range(1, len(nums)):
            if nums[i] == nums[i - 1]:
                count += 1
            else:
                count = 1

            if count <= 2:
                nums[j] = nums[i]
                j += 1

        return j




if __name__ == "__main__":

    # https://leetcode-cn.com/problems/remove-duplicates-from-sorted-array-ii/
    nums = [1,1,1,2,2,3]
    Solution().removeDuplicates(nums)
    print(nums)

