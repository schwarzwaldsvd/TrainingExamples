using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExamples
{
    public class Program
    {
        public static void Main()
        {
            int[] num1 = {3,2,4};
            var target = 6;
            Solution.TwoSum(num1,target);
        }

        
    }

    public static class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i>0)
                {
                    if (nums[i] + nums[i-1]==target)
                    {

                    }
                }
                
                Console.WriteLine(nums[i]);
            }

            int[] ret;
            ret = new int[3];

            return ret;
        }
    }
}
