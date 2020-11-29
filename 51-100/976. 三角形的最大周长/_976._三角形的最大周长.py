from typing import List


class Solution:
    def largestPerimeter(self, A: List[int]) -> int:
        # 注意: 非原地排序
        A = sorted(A)
        for i in range(len(A) - 1, 1,-1):
            if (A[i - 2] + A[i - 1] > A[i]):
                return A[i - 2] + A[i - 1] + A[i]

        return 0


if __name__ == "__main__":

    # https://leetcode-cn.com/problems/largest-perimeter-triangle/


    sol = Solution()
    result = sol.largestPerimeter([2,1,2])
    print(result)