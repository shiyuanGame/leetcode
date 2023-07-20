/*
 * @lc app=leetcode.cn id=1 lang=csharp
 * @lcpr version=21909
 *
 * [1] 两数之和
 */

// @lc code=start
using System;
using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(target - nums[i]))
            {
                return new int[] { dict[target - nums[i]], i };
            }
            else if (!dict.ContainsKey(nums[i])) // handles duplicates in array
            {
                dict.Add(nums[i], i);
            }
        }
        return null;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [2,7,11,15]\n9\n
// @lcpr case=end

// @lcpr case=start
// [3,2,4]\n6\n
// @lcpr case=end

// @lcpr case=start
// [3,3]\n6\n
// @lcpr case=end

 */

