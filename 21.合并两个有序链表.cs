/*
 * @lc app=leetcode.cn id=21 lang=csharp
 * @lcpr version=21910
 *
 * [21] 合并两个有序链表
 */

// @lc code=start 
//  Definition for singly-linked list.
using System.Collections.Generic;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode prehead = new ListNode(-1);
        ListNode prev = prehead;
        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                prev.next = list1;
                list1 = list1.next;
            }
            else
            {
                prev.next = list2;
                list2 = list2.next;
            }
            prev = prev.next;
        }
        prev.next = list1 == null ? list2 : list1;

        return prehead.next;
    }
}
public class Solution3
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode prehead = new ListNode(-1);
        ListNode prev = prehead;


        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                prev.next = list1;
                list1 = list1.next;
            }
            else
            {
                prev.next = list2;
                list2 = list2.next;
            }
            prev = prev.next;
        }
        prev.next = list1 == null ? list2 : list1;
        return prehead;
    }
}
public class Solution2
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null)
        {
            return list2;
        }
        else if (list2 == null)
        {
            return list1;
        }
        else if (list2.val <= list1.val)
        {
            list2.next = MergeTwoLists(list1, list2.next);
            return list2;
        }
        else
        {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,4]\n[1,3,4]\n
// @lcpr case=end

// @lcpr case=start
// []\n[]\n
// @lcpr case=end

// @lcpr case=start
// []\n[0]\n
// @lcpr case=end

 */

