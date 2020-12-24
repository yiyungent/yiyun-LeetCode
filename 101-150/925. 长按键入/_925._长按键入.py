
class Solution:

    # 方法1：双指针
    # 字符串 typed 的每个字符，有且只有两种 [用途]
    # - 作为 name 的一部分，此时会 [匹配] name 中的一个字符
    # - 作为长按键入的一部分。此时它应当与前一个字符相同
    # 若 typed 中存在一个字符，它两个条件均无满足，则应当直接返回 false，
    # 否则，当 typed 扫描完毕后，我们再检查 name 的每个字符是否都被 [匹配] 了。
    def isLongPressedName(self, name: str, typed: str) -> bool:
          i,j = 0,0

          while j < len(typed):
              if i < len(name) and name[i] == typed[j]:
                  i += 1
                  j += 1
              elif j > 0 and typed[j] == typed[j - 1]:
                  j += 1
              else:
                  return False

          return i == len(name)



if __name__ == "__main__":

    # https://leetcode-cn.com/problems/long-pressed-name/
    name = "alex"
    typed = "aaleex"
    print(Solution().isLongPressedName(name, typed))
