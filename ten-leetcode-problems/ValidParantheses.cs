using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ten_leetcode_problems
{
    internal static class ValidParantheses
    {
        public static bool IsValidParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {

                if (c == '(' || c == '[' || c == '{')
                    stack.Push(c);


                if (c == ')' && ((stack.Count == 0) || stack.Pop() != '('))
                    return false;
                if (c == '}' && (stack.Count == 0 || stack.Pop() != '{'))
                    return false;
                if (c == ']' && (stack.Count == 0 || stack.Pop() != '['))
                    return false;

            }


            return (stack.Count == 0);

        }
    }
}
