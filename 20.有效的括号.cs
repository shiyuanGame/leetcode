/*
 * @lc app=leetcode.cn id=20 lang=csharp
 * @lcpr version=21909
 *
 * [20] 有效的括号
 */

// @lc code=start


using System.Collections.Generic;

public class Solution
{

    Stack<char> stack = new Stack<char>();
    Dictionary<char, char> dic = new Dictionary<char, char>()
    {
    {']','['},
    {')','('},
    {'}','{'},
    };
    public bool IsValid(string s)
    {
        if (s == null || (s != null && s.Length == 0) || (s != null && s.Length % 2 == 1))
        {
            return false;
        }


        for (var i = 0; i < s.Length; i++)
        {
            var ch = s[i];
            if (dic.ContainsKey(ch))
            {
                if (stack.Count == 0 || stack.Peek() != dic[ch])
                {
                    System.Console.WriteLine("...........");
                    return false;
                }
                stack.Pop();
            }
            else
            {
                stack.Push(ch);
            }

        }
        return stack.Count == 0;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "()"\n
// @lcpr case=end

// @lcpr case=start
// "()[]{}"\n
// @lcpr case=end

// @lcpr case=start
// "(]"\n
// @lcpr case=end

 */

