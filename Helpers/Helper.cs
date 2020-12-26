using System;
using System.Collections.Generic;

namespace Helpers
{
    public static class Helper
    {
        public static string Array2String<T>(IEnumerable<T> list)
        {
            return "[" + string.Join(",", list) + "]";
        }

        public static void Print(string testName, int[] a)
        {
            Console.WriteLine($"{testName}: ");
            Console.WriteLine(Array2String(a));
            Console.WriteLine();
        }
    }
}
