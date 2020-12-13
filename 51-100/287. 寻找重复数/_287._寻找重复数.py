from typing import List


class Solution:

    # 方法1: 
    def findDuplicate(self, nums: List[int]) -> int:
        size = len(nums)
        left = 1
        right = size - 1

        while left < right:
            mid = left + (right - left) // 2

            cnt = 0
            for num in nums:
                if num <= mid:
                    cnt += 1

            if cnt > mid:
                right = mid
            else:
                left = mid + 1

        return left


if __name__ == "__main__":

    # https://leetcode-cn.com/problems/find-the-duplicate-number/

    print(Solution().findDuplicate([1,3,4,2,2]))



