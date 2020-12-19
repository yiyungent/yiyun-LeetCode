from typing import List

class Solution:

    # 方法1：排序+双指针
    # 时间复杂度：O(mlogm + nlogn) ，其中 m 和 n 分别是两个数组的长度
    # 空间复杂度：O(logm + logn) ，其中 m 和 n 分别是两个数组的长度，空间复杂度主要取决于排序使用的额外空间
    def intersection(self, nums1: List[int], nums2: List[int]) -> List[int]:
        nums1.sort()
        nums2.sort()
        length1, length2 = len(nums1), len(nums2)
        intersection = list()
        index1 = index2 = 0
        while index1 < length1 and index2 < length2:
            num1 = nums1[index1]
            num2 = nums2[index2]
            if num1 == num2:
                # 保证加入元素的唯一性
                if not intersection or num1 != intersection[-1]:
                    intersection.append(num1)
                index1 += 1
                index2 += 1
            elif num1 < num2:
                index1 += 1
            else:
                index2 += 1

        return intersection



if __name__ == "__main__":
    
    # https://leetcode-cn.com/problems/intersection-of-two-arrays/

    nums1 = [1,2,2,1]
    nums2 = [2,2]
    print(Solution().intersection(nums1, nums2))



