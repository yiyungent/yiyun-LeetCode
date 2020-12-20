
# Definition for singly-linked list.
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


class Solution:

    # 方法1: 追随指针
    def removeNthFromEnd(self, head: ListNode, n: int) -> ListNode:
        # 在最前添加一个节点，用于接 head
        dummy = ListNode(0, head)
        # 快指针: right, 慢指针: left
        left, right = dummy, head
        # 1. 先让 right 快指针 走 n 步
        for i in range(n):
            right = right.next
        # 2. 再 慢指针，快指针 一起走
        # 直到 快指针走到终点（注意，走到末节点就可以了）
        while right != None:
            right = right.next
            left = left.next

        # 跳过中间的节点（即删除倒数第n个节点）
        left.next = left.next.next

        # 注意：返回的是 dummy.next
        return dummy.next



if __name__ == "__main__":

    # https://leetcode-cn.com/problems/remove-nth-node-from-end-of-list/
    pass
