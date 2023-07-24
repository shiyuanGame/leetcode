/*
 * @lc app=leetcode.cn id=83 lang=csharp
 * @lcpr version=21912
 *
 * [83] 删除排序链表中的重复元素
 */

// @lc code=start

//  Definition for singly-linked list.
// using System.Collections.Generic;

// public class ListNode
// {
//     public int val;
//     public ListNode next;
//     public ListNode(int val = 0, ListNode next = null)
//     {
//         this.val = val;
//         this.next = next;
//     }
// }

public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null) return null;
        ListNode virtualHead = head;

        while (virtualHead.next != null)
        {
            if (virtualHead.val == virtualHead.next.val)
            {
                virtualHead.next = virtualHead.next.next;
            }
            else
            {
                virtualHead = virtualHead.next;
            }
        }
        return head;
    }
}
// public class Solution2
// {

//     public ListNode DeleteDuplicates(ListNode head)
//     {
//         Dictionary<int, ListNode> dic = new Dictionary<int, ListNode>() { { head.val, head } };
//         if (head == null) return null;
//         ListNode virtualHead = head;

//         while (virtualHead.next != null)
//         {
//             if (dic.ContainsKey(virtualHead.next.val))
//             {
//                 virtualHead.next = virtualHead.next.next;
//             }
//             else
//             {
//                 dic.Add(virtualHead.next.val, virtualHead.next);
//                 virtualHead = virtualHead.next;
//             }
//         }
//         return head;
//     }
// }
// @lc code=end



/*
// @lcpr case=start
// [1,1,2]\n
// @lcpr case=end

// @lcpr case=start
// [1,1,2,3,3]\n
// @lcpr case=end

 */

