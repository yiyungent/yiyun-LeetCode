
# Definition for singly-linked list.
class ListNode:
    def __init__(self, x):
        self.val = x
        self.next = None

class Solution:

    # 方法1: 双指针1
    # 我们可用 两指针 before 和 after 来追踪 上述的两链表。
    # 两指针 可用于 分别创建两链表，然后将 两链表 连接后 即可 获得所需 链表
    # 时间复杂度：O(N)
    # 空间复杂度：O(1)
    def partition(self, head: ListNode, x: int) -> ListNode:
        # 将两个指针初始化为 哑 ListNode
        before = before_head = ListNode(0)
        after = after_head = ListNode(0)

        while head:
            # If the original list node is lesser than the given x,
            # assign it to the before list.
            if head.val < x:
                before.next = head
                before = before.next
            else:
                # If the original list node is greater or equal to the given x,
                # assign it to the after list.
                after.next = head
                after = after.next

            # move ahead in the original list
            head = head.next

        # Last node of "after" list would also be ending node of the reformed list
        after.next = None
        # Once all the nodes are correctly assigned to the two lists.
        # combine them to form a single list which would be returned.
        before.next = after_head.next
        
        return before_head.next

if __name__ == "__main__":
    
    # https://leetcode-cn.com/problems/partition-list/
    pass

