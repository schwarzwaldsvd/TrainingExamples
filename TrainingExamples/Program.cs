using System;
using System.Collections.Generic;

namespace TwoSum
{
    public class Program
    {
        public static void Main()
        {
            int[] s = { 11, 2, 15, 7, 3, 11};
            var value = 9;


            Console.WriteLine($"Input: {Array2String(s)}; target: {value}");

            try
            {
                var r1 = new ReturnIndexBruteForce();
                int[] a1 = r1.TwoSum(s, value);
                Console.WriteLine("Brute Force: ");
                Console.WriteLine(Array2String(a1));
                Console.WriteLine();
                
                var r2 = new ReturnIndexTwoPassDictionary();
                int[] a2 = r2.TwoSum(s, value);
                Console.WriteLine("Two-Pass Dictionary: ");
                Console.WriteLine(Array2String(a2));
                Console.WriteLine();

                var r3 = new ReturnIndexOnePassDictionary();
                int[] a3 = r3.TwoSum(s, value);
                Console.WriteLine("One-Pass Dictionary: ");
                Console.WriteLine(Array2String(a3));
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");                
            }
        }

        private static string Array2String<T>(IEnumerable<T> list)
        {
            return "[" + string.Join(",", list) + "]";
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
