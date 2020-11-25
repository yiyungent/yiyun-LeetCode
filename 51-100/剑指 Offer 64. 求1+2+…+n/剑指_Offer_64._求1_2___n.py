
class Solution:
    def __init__(self):
        self.res = 0

    def sumNums(self, n: int) -> int:
        """
        方法一：递归
        """
        # 利用 逻辑与 实现 if else 效果
        n > 1  and self.sumNums(n - 1)
        self.res += n

        return self.res
        



if __name__ == "__main__":
    # https://leetcode-cn.com/problems/qiu-12n-lcof/
    
    print(Solution().sumNums(3))
