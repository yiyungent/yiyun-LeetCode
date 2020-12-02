
# Definition for singly-linked list.
class ListNode:
    def __init__(self, x):
        self.val = x
        self.next = None

class Solution:

    # 双指针: 追随指针
    def kthToLast(self, head: ListNode, k: int) -> int:
        prev = head
        after = head
        # 先让 prev 走 k步, prev 在 after 前 k
        for i in range(k):
            prev = prev.next
        # 再一起走，直到 prev 走完
        while prev:
            prev = prev.next
            after = after.next

        return after.val


if __name__ == "__main__":

    # https://leetcode-cn.com/problems/kth-node-from-end-of-list-lcci/

    sol = Solution()
    node1 = ListNode(1)
    node2 = ListNode(2)
    node3 = ListNode(3)
    node4 = ListNode(4)
    node5 = ListNode(5)
    node1.next = node2
    node2.next = node3
    node3.next = node4
    node4.next = node5

    res = sol.kthToLast(node1, 2)
    print(res)
