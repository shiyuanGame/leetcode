/*
 * @lc app=leetcode.cn id=88 lang=csharp
 * @lcpr version=21912
 *
 * [88] 合并两个有序数组
 */

// @lc code=start
using System;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int[] tempData = new int[n + m];
        int p1 = 0, p2 = 0;
        while (p1 < m || p2 < n)
        {
            int value = -1;
            int index = p1 + p2;
            if (p1 == m)
            {
                value = nums2[p2++];
            }
            else if (p2 == n)
            {
                value = nums1[p1++];
            }
            else if (nums1[p1] <= nums2[p2])
            {
                value = nums1[p1++];

            }
            else if (nums1[p1] > nums2[p2])
            {
                value = nums2[p2++];

            }
            tempData[index] = value;
        }

        for (var i = 0; i < tempData.Length; i++)
        {
            nums1[i] = tempData[i];
        }

    }
}
// public class Solution2
// {
//     public void Merge(int[] nums1, int m, int[] nums2, int n)
//     {
//         for (var i = 0; i < n; i++)
//         {
//             nums1[i + m] = nums2[i];

//         }
//         Array.Sort(nums1);
//     }
// }
// @lc code=end



/*
// @lcpr case=start
// [1,2,3,0,0,0]\n3\n[2,5,6]\n3\n
// @lcpr case=end

// @lcpr case=start
// [1]\n1\n[]\n0\n
// @lcpr case=end

// @lcpr case=start
// [0]\n0\n[1]\n1\n
// @lcpr case=end

 */

