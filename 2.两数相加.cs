/*
 * @lc app=leetcode.cn id=2 lang=csharp
 * @lcpr version=21909
 *
 * [2] 两数相加
 */

//  @lc code=start

//  Definition for singly-linked list.
using System.Collections.Generic;
using System.Linq;
using System.Threading;

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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var num1 = returnResult(l1);
        var num2 = returnResult(l2);
        var sub = num1 + num2;


    }
    public int[] arrayResult(int num)
    {
        List<int> add = new List<int>();

    }

    public int returnResult(ListNode listNode)
    {
        var hand = listNode;
        List<int> list1 = new List<int>();
        while (hand.next != null)
        {
            list1.Add(hand.val);
            hand = hand.next;
        }
        list1 = list1.Reverse();

        int tempCount1 = 0;
        for (var i = 0; i < list1.Count; i++)
        {
            tempCount1 += (list1.Count - i) * list1[i];
        }
        return tempCount;
    }
}

public class Solution2
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode head = null, tail = null;
        int carry = 0;
        while (l1 != null || l2 != null)
        {
            int n1 = l1 != null ? l1.val : 0;
            int n2 = l2 != null ? l2.val : 0;
            int sum = n1 + n2 + carry;
            if (head == null)
            {
                head = tail = new ListNode(sum % 10);
            }
            else
            {
                tail.next = new ListNode(sum % 10);
                tail = tail.next;
            }
            carry = sum / 10;
            if (l1 != null)
            {
                l1 = l1.next;
            }
            if (l2 != null)
            {
                l2 = l2.next;
            }
        }
        if (carry > 0)
        {
            tail.next = new ListNode(carry);
        }
        return head;
    }
}
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new ListNode(); // 创建一个虚拟头节点
        ListNode current = dummyHead; // 创建一个指针指向当前节点
        int carry = 0; // 进位值，初始为0

        while (l1 != null || l2 != null)
        {
            int x = (l1 != null) ? l1.val : 0; // 获取l1节点的值，如果l1为空则取0
            int y = (l2 != null) ? l2.val : 0; // 获取l2节点的值，如果l2为空则取0
            int sum = carry + x + y; // 计算当前节点的值

            carry = sum / 10; // 更新进位值
            current.next = new ListNode(sum % 10); // 创建新节点，并将当前节点指向它
            current = current.next; // 将指针移动到下一个节点

            if (l1 != null)
                l1 = l1.next; // 移动l1指针到下一个节点
            if (l2 != null)
                l2 = l2.next; // 移动l2指针到下一个节点
        }

        if (carry > 0)
        {
            current.next = new ListNode(carry); // 如果还有进位值，创建一个新节点
        }

        return dummyHead.next; // 返回虚拟头节点的下一个节点，即链表的头节点
    }
}

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // 创建示例链表
//         ListNode l1 = new ListNode(2);
//         l1.next = new ListNode(4);
//         l1.next.next = new ListNode(3);

//         ListNode l2 = new ListNode(5);
//         l2.next = new ListNode(6);
//         l2.next.next = new ListNode(4);

//         // 创建Solution对象并调用AddTwoNumbers方法
//         Solution solution = new Solution();
//         ListNode result = solution.AddTwoNumbers(l1, l2);

//         // 输出结果链表的值
//         while (result != null)
//         {
//             Console.Write(result.val + " ");
//             result = result.next;
//         }
//     }
// }
// @lc code=end



/*
// @lcpr case=start
// [2,4,3]\n[5,6,4]\n
// @lcpr case=end

// @lcpr case=start
// [0]\n[0]\n
// @lcpr case=end

// @lcpr case=start
// [9,9,9,9,9,9,9]\n[9,9,9,9]\n
// @lcpr case=end

 */

