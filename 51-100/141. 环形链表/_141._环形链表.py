
# Definition for singly-linked list.
class ListNode:
    def __init__(self, x):
        self.val = x
        self.next = None

class Solution:

    # 方法1: 双指针
    # 时间复杂度: O(n)  n 是链表中的节点数
    # 空间复杂度: O(1)  我们只使用了两个指针的额外空间
    def hasCycle(self, head: ListNode) -> bool:
        if head == None or head.next == None:
            return False

        # 初始化位置: 快指针在前1步，为的是：让循环能运行
        slow = head
        fast = head.next

        while slow != fast:
            if fast == None or fast.next == None:
                return False
            slow = slow.next
            fast = fast.next.next

        return True


if __name__ == "__main__":

    # https://leetcode-cn.com/problems/linked-list-cycle/
    pass

