using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ten_leetcode_problems
{
    internal static class ReverseString
    {
        static internal void Reverse(char[] s)
        {
            Stack<char> stack = new();
            for (int i = 0; i < s.Length; i++)
                stack.Push(s[i]);

            for (int i = 0; i < s.Length; i++)
                s[i] = stack.Pop();

        }
    }
}
