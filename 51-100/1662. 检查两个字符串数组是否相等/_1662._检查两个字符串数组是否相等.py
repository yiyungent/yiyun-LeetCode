from typing import List

class Solution:
    #def arrayStringsAreEqual(self, word1: List[str], word2: List[str]) -> bool:
    #    str1 = ''
    #    str2 = ''
    #    for w1 in word1:
    #        str1+=w1
        
    #    for w2 in word2:
    #        str2+=w2
        
    #    return str1 == str2

    def arrayStringsAreEqual(self, word1: List[str], word2: List[str]) -> bool:
        """
            方法2
        """
        word1_str = ''.join(word1)
        word2_str = ''.join(word2)

        if word1_str == word2_str:
            return True
        else:
            return False



# https://leetcode-cn.com/problems/check-if-two-string-arrays-are-equivalent/

sol = Solution()
result = sol.arrayStringsAreEqual(["ab", "c"], ["a", "bc"])
print(result)

