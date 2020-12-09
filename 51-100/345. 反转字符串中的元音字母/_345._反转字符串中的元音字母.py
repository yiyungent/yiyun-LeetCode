
class Solution:

    # 判断一个字符是否是元音字母
    def isVowel(self, c) -> bool:
        return c == 'a' or c == 'e' or c == 'i' or c == 'o' or c == 'u'  or c == 'A' or c == 'E' or c == 'I' or c == 'O' or c == 'U'


    # 方法1: 对撞指针
    # 时间复杂度: O(n)  n 为字符串长度
    # 空间复杂度: O(1)
    def reverseVowels(self, s: str) -> str:
        if s == None or len(s) <= 0: return s

        chars = [i for i in s]
        print(chars)
        # 左指针 向右移动
        i = 0
        # 右指针 向左移动
        j = len(s) - 1

        # 直到 两指针 对撞
        while i < j:
            # 从左到右 找到元音
            while i < len(chars) and not self.isVowel(chars[i]):
                i+=1
            # 从右向左 找到元音
            while j >= 0 and not self.isVowel(chars[j]):
                j-=1
            if i < j:
                temp = chars[i]
                chars[i] = chars[j]
                chars[j] = temp
                i += 1
                j -= 1

        return "".join(chars)
        



if __name__ == "__main__":

    # https://leetcode-cn.com/problems/reverse-vowels-of-a-string/

    Solution().reverseVowels("leetcode")