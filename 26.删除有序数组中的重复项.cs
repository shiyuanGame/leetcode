/*
 * @lc app=leetcode.cn id=26 lang=csharp
 * @lcpr version=21910
 *
 * [26] 删除有序数组中的重复项
 */

// @lc code=start
using System.Collections.Generic;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {

        int n = nums.Length;
        if (n <= 0)
            return 0;

        int fast = 0, slow = 0;
        while (fast < n)
        {
            if (nums[fast] != nums[fast - 1])
            {
                nums[slow] = nums[fast];
                ++slow;
            }
            ++fast;

        }
        return slow;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,1,2]\n
// @lcpr case=end

// @lcpr case=start
// [0,0,1,1,1,2,2,3,3,4]\n
// @lcpr case=end

 */

