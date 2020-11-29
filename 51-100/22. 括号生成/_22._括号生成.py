from typing import List


class Solution:

    # 方法1: 递归法
    # 时间复杂度: O(2^(2n) * n)
    # 空间复杂度: O(n)
    def generateParenthesis(self, n: int) -> List[str]:
        def generate(A):
            if len(A) == 2*n:
                if valid(A):
                    ans.append("".join(A))
            else:
                A.append('(')
                generate(A)
                A.pop()
                A.append(')')
                generate(A)
                A.pop()

        def valid(A):
            bal = 0
            for c in A:
                if c == '(': bal += 1
                else: bal -= 1
                if bal < 0: return False
            return bal == 0

        ans = []
        generate([])
        return ans


if __name__ == "__main__":

    # https://leetcode-cn.com/problems/generate-parentheses/


    sol = Solution()
    result = sol.generateParenthesis(3)
    print(result)