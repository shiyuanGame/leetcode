/*
 * @lc app=leetcode.cn id=66 lang=csharp
 * @lcpr version=21912
 *
 * [66] 加一
 */

// @lc code=start
public class Solution2
{
    public int[] PlusOne(int[] digits)
    {
        int[] array = null;
        bool isAll = true;
        for (var i = 0; i < digits.Length; i++)
        {
            if (digits[i] != 9)
            {
                isAll = false;
                break;
            }
        }
        var ismoveIndex = isAll ? 1 : 0;
        if (isAll)
        {
            array = new int[digits.Length + 1];
            array[0] = 1;
        }
        else
        {
            array = new int[digits.Length];
        }

        var isAdd1 = 1;

        for (var i = digits.Length - 1; i >= 0; i--)
        {
            var tempValue = digits[i] + isAdd1;
            isAdd1 = tempValue / 10;
            digits[i] = tempValue % 10;
            array[i + ismoveIndex] = digits[i];
        }
        return array;


    }
}

public class Solution
{
    //  1 2  9
    public int[] PlusOne(int[] digits)
    {
        int n = digits.Length;
        //i=2
        for (int i = n - 1; i >= 0; --i)
        {
            if (digits[i] != 9)
            {
                ++digits[i]; //4
                for (int j = i + 1; j < n; ++j)
                {
                    digits[j] = 0;
                }
                return digits;
            }
        }

        // digits 中所有的元素均为 9
        int[] ans = new int[n + 1];
        ans[0] = 1;
        return ans;
    }
}


// @lc code=end



/*
// @lcpr case=start
// [1,2,3]\n
// @lcpr case=end

// @lcpr case=start
// [4,3,2,1]\n
// @lcpr case=end

// @lcpr case=start
// [0]\n
// @lcpr case=end

 */

