// 234. 回文链表.cpp 

#include <iostream>
#include <stdbool.h>


// Definition for singly-linked list.
struct ListNode {
    int val;
    struct ListNode *next;
};

struct ListNode* reverseList(struct ListNode* head) {
    struct ListNode* prev = NULL;
    struct ListNode* curr = head;
    while (curr != NULL) {
        struct ListNode* nextTemp = curr->next;
        curr->next = prev;
        prev = curr;
        curr = nextTemp;
    }
    return prev;
}

struct ListNode* endOfFirstHalf(struct ListNode* head) {
    struct ListNode* fast = head;
    struct ListNode* slow = head;
    while (fast->next != NULL && fast->next->next != NULL) {
        fast = fast->next->next;
        slow = slow->next;
    }
    return slow;
}
 
// 方法1：快慢指针
bool isPalindrome(struct ListNode* head) {
    if (head == NULL) {
        return true;
    }

    // 找到 前半部分链表的尾结点 并反转 后半部分链表
    struct ListNode* firstHalfEnd = endOfFirstHalf(head);
    struct ListNode* secondHalfStart = reverseList(firstHalfEnd->next);

    // 判断是否回文
    struct ListNode* p1 = head;
    struct ListNode* p2 = secondHalfStart;
    bool result = true;
    while (result && p2 != NULL) {
        if (p1->val != p2->val) {
            result = false;
        }
        p1 = p1->next;
        p2 = p2->next;
    }

    // 还原链表 并返回结果
    firstHalfEnd->next = reverseList(secondHalfStart);
    return result;
}


int main()
{
    // https://leetcode-cn.com/problems/palindrome-linked-list/
    // 1->2->2->1
    


}


