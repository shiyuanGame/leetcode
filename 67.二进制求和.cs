/*
 * @lc app=leetcode.cn id=67 lang=csharp
 * @lcpr version=21912
 *
 * [67] 二进制求和
 */

// @lc code=start
using System;
using System.Linq;
using System.Text;

public class Solution
{
    public string AddBinary(string a, string b)
    {

        var n = MathF.Max(a.Length, b.Length);
        int index = 0, carry = 0; ;
        StringBuilder sum = new StringBuilder();

        while (index < n)
        {
            int digit1 = a.Length > index ? a[a.Length - 1 - index] - '0' : 0;
            int digit2 = b.Length > index ? b[b.Length - 1 - index] - '0' : 0;
            var tempSum = digit1 + digit2 + carry;
            // System.Console.WriteLine(tempSum + "," + digit1 + "," + digit2 + "," + carry + "----" + index);

            carry = tempSum / 2;

            sum.Append(tempSum % 2);
            index++;
        }
        if (carry > 0)
        {
            sum.Append('1');
        }
        return new string(sum.ToString().Reverse().ToArray());
    }
}
// @lc code=end



/*
// @lcpr case=start
// "11"\n"1"\n
// @lcpr case=end

// @lcpr case=start
// "1010"\n"1011"\n
// @lcpr case=end

 */

