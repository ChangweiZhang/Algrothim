using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Solution();
            var testcase = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var result = program.TwoSum(testcase, target);

        }


    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var val = nums[i];
                if (dict.ContainsKey(val))
                {
                    return new int[] { dict[val], i };
                }

                dict[target - val] = i;

            }
            return null;
        }
    }
}
