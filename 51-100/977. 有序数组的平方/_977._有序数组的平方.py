from typing import List

class Solution:

    # 方法1: 直接排序
    # 时间复杂度: O(nlogn)     n 是 数组nums的长度
    # 空间复杂度: O(logn)      除了存储答案的数组外，我们需要 O(logn) 的栈空间进行排序
    #def sortedSquares(self, nums: List[int]) -> List[int]:
    #    return sorted(num*num for num in nums)

    # 方法2: 双指针
    # 时间复杂度: O(n)  其中 n 是数组的长度
    # 空间复杂度: O(1)
    def sortedSquares(self, nums: List[int]) -> List[int]:
        n = len(nums)
        negative = -1
        for i, num in enumerate(nums):
            if num < 0:
                negative = i
            else:
                break
       
        ans = list()
        i, j = negative, negative + 1
        while i >= 0 or j < n:
            if i < 0:
                ans.append(nums[j] * nums[j])
                j += 1
            elif j == n:
                ans.append(nums[i] * nums[i])
                i -= 1
            elif nums[i] * nums[i] < nums[j] * nums[j]:
                ans.append(nums[i] * nums[i])
                i -= 1
            else:
                ans.append(nums[j] * nums[j])
                j += 1

        return ans




if __name__ == "__main__":

    # https://leetcode-cn.com/problems/squares-of-a-sorted-array/

    print(Solution().sortedSquares([-4,-1,0,3,10]))


