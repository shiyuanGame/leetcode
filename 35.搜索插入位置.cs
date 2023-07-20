/*
 * @lc app=leetcode.cn id=35 lang=csharp
 * @lcpr version=21910
 *
 * [35] 搜索插入位置
 */

// @lc code=start
public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1, ans = nums.Length;
        while (left <= right)
        {
            int mid = (right - left) / 2 + left;
            if (nums[mid] < target)
            {
                left = mid + 1;

            }
            else
            {
                ans = mid;
                right = mid - 1;
            }
        }
        return ans;
    }


}
// @lc code=end



/*
// @lcpr case=start
// [1,3,5,6]\n5\n
// @lcpr case=end

// @lcpr case=start
// [1,3,5,6]\n2\n
// @lcpr case=end

// @lcpr case=start
// [1,3,5,6]\n7\n
// @lcpr case=end

 */

