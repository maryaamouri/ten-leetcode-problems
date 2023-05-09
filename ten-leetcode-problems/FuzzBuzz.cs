using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ten_leetcode_problems
{
    internal static class Fizz_Buzz
    {
        internal static string[] FindFizzBuzz(int n)
        {

            var result = new string[n];
            for (int index = 0, i = 1; index < n; i++, index++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    result[index] = "FizzBuzz";
                else if (i % 3 == 0)
                    result[index] = "Fizz";
                else if (i % 5 == 0)
                    result[index] = "Buzz";
                else result[index] = i.ToString();
            }
            return result;
        }
    }
}
