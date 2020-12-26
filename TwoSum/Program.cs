using System;
using System.Collections.Generic;
using Helpers;

namespace TwoSum
{
    public class Program
    {
        public static void Main()
        {
            int[] s = { 11, 2, 15, 7, 3, 11};
            var value = 9;


            Console.WriteLine($"Input: {Helper.Array2String(s)}; target: {value}");

            try
            {
                var r1 = new ReturnIndexBruteForce();
                int[] a1 = r1.TwoSum(s, value);
                Helper.Print("Brute Force",a1);
                
                
                var r2 = new ReturnIndexTwoPassDictionary();
                int[] a2 = r2.TwoSum(s, value);
                Helper.Print("Two-Pass Dictionary", a2);
                
                var r3 = new ReturnIndexOnePassDictionary();
                int[] a3 = r3.TwoSum(s, value);
                Helper.Print("One-Pass Dictionary", a3);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");                
            }
        }
    }

    

    public class ReturnIndexBruteForce
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[]{i,j};
                    }
                }
            }

            throw new ArgumentException("No two sum solution");
        }
    }

    public class ReturnIndexTwoPassDictionary
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var d = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                //d.Add(nums[i],i); // --> this will throw an ArgumentException if Adding a duplicate key
                d[nums[i]] = i;     // --> will replace the existing value with the new one if you use [] indexing
            }

            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];

                if (d.ContainsKey(complement) && (int)d[complement] != i)
                {
                    return new int[] { i, (int)d[complement] };
                }
            }
            throw new ArgumentException("No two sum solution");
        }
    }

    public class ReturnIndexOnePassDictionary
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var d = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (d.ContainsKey(complement))
                {
                    return new int[]{(int)d[complement], i};
                }
                d[nums[i]] = i;
            }
            throw new ArgumentException("No two sum solution");
        }
    }
}
