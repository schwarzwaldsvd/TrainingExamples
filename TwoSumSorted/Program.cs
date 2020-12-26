using Helpers;
using System;
using System.Collections.Generic;

namespace TwoSumSorted
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 2, 7, 11, 15 };
            var target = 9;
            Array.Sort(numbers);

            try
            {
                var r1 = new ReturnIndex();
                int[] a1 = r1.TwoSum(numbers, target);
                Helper.Print("TwoSum sorted array", a1);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            
        }
    }

    public class ReturnIndex
    {
        public int[] TwoSum(int[] nums, int target)
        {
            
            var d = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (d.ContainsKey(complement))
                {
                    if (i>d[complement])
                    {
                        return new int[] { (int)d[complement]+1, i+1 };
                    }
                }
                d[nums[i]] = i;
            }

            throw new ArgumentException("No two sum solution");
        }
    }

}
