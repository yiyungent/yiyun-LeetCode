# Definition for singly-linked list.
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


class Solution:

    # 方法1: 快慢指针
    def mergeInBetween(self, list1: ListNode, a: int, b: int, list2: ListNode) -> ListNode:
        fast, slow = list1, list1
        k = b - a + 1
        for _ in range(k):
            fast = fast.next
        for _ in range(a-1):
            slow = slow.next
            fast = fast.next
        end = fast.next
        pre, rear = list2, list2
        while rear.next:
            rear = rear.next
        slow.next = pre
        rear.next = end

        return list1




if __name__ == "__main__":


     # https://leetcode-cn.com/problems/merge-in-between-linked-lists/


