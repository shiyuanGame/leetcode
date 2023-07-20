/*
 * @lc app=leetcode.cn id=27 lang=csharp
 * @lcpr version=21910
 *
 * [27] 移除元素
 */

// @lc code=start
public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int n = nums.Length;
        if (n <= 0) return 0;
        int left = 0, right = nums.Length - 1;

        while (left <= right)
        {

            while (left <= right && nums[left] != val)
            {
                ++left;
            }
            while (left <= right && nums[right] == val)
            {
                --right;
            }
            if (left < right)
            {
                // int temp = nums[left];
                // nums[left] = nums[right];
                // nums[right] = temp;

                nums[left++] = nums[right--];
            }

            System.Console.WriteLine(left);
        }
        return left;
    }
}
// @lc code=end



/*
// @lcpr case=start
// [3,2,2,3]\n3\n
// @lcpr case=end

// @lcpr case=start
// [0,1,2,2,3,0,4,2]\n2\n
// @lcpr case=end

 */

