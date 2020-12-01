from typing import List

class Solution:

    # 方法1: 循环遍历
    #def maximumWealth(self, accounts: List[List[int]]) -> int:
    #    maxVal = 0
    #    for i in range(0, len(accounts)):
    #        temp = 0
    #        for j in range(0, len(accounts[i])):
    #            temp = temp + accounts[i][j]
    #        if temp > maxVal:
    #            maxVal = temp

    #    return maxVal

    # 方法2: 循环遍历 简化代码
    def maximumWealth(self, accounts: List[List[int]]) -> int:
        return max(sum(i) for i in accounts)




# https://leetcode-cn.com/problems/richest-customer-wealth/

sol = Solution()
res = sol.maximumWealth([[1,5],[7,3],[3,5]])
print(str(res) + '\n')

res = sol.maximumWealth([[2,8,7],[7,1,3],[1,9,5]])
print(res)