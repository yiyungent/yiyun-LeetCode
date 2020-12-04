from typing import List


class Solution:

    # 方法一：贪心算法 + 双指针
    def partitionLabels(self, S: str) -> List[int]:
        last = [0] * 26
        for i, ch in enumerate(S):
            last[ord(ch) - ord("a")] = i

        partition = list()
        start = end = 0
        for i, ch in enumerate(S):
            end = max(end, last[ord(ch) - ord("a")])
            if i == end:
                partition.append(end - start + 1)
                start = end + 1

        return partition



if __name__ == "__main__":


    # https://leetcode-cn.com/problems/partition-labels/

    sol = Solution()
    res = sol.partitionLabels("ababcbacadefegdehijhklij")
    print(res)