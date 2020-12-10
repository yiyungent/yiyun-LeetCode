from typing import List

class Solution:

    # 方法1: 双指针
    # https://leetcode-cn.com/problems/fruit-into-baskets/solution/python-shuang-zhi-zhen-ono1jie-fa-by-hardcandy/
    # TODO: 904. 水果成篮
    def totalFruit(self, tree: List[int]) -> int:
        ans, n = 0, len(tree)
        i, j = 0, 0
        types = {}
        while j < n:
            if len(types) == 2 and types.get(tree[j]) is None: # 当前水果不可加入
                types = {}
                j = i  # j 回退到最后一次翻转的位置
            else:   # 当前水果可加入
                types[tree[j]] = types.get(tree[j], 0) + 1
                if tree[j] != tree[i]:  # 水果有翻转 用 i 记录下翻转的位置
                    i = j
                j += 1
            ans = max(ans, sum(types.values()))

        return ans



if __name__ == "__main__":
    
    # https://leetcode-cn.com/problems/fruit-into-baskets/

    print(Solution().totalFruit([1,2,1]))