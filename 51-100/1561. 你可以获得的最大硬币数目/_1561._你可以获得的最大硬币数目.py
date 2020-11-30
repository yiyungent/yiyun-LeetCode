from typing import List

class Solution:

    # 方法1: 贪心算法
    # 时间复杂度: O(nlogn)，其中 n 是数组的长度除以3（即数组的长度是3n）。
    # 空间复杂度: O(logn)
    def maxCoins(self, piles: List[int]) -> int:
        n = len(piles)
        piles.sort()
        return sum(piles[n//3::2])



# https://leetcode-cn.com/problems/maximum-number-of-coins-you-can-get/

sol = Solution()
result = sol.maxCoins([2,4,1,2,7,8])
print(result)

