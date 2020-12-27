using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Solution
    {
        public LinkedListNode<int> AddTwoNumbers(LinkedListNode<int> l1, LinkedListNode<int> l2)
        {
            var dummyHead = new LinkedListNode<int>(0);
            var p1 = l1;
            var p2 = l2;
            var current = dummyHead;
            var carry = 0;
            while (p1 != null || p2 != null)
            {
                var x = p1?.Value ?? 0;
                var y = p2?.Value ?? 0;
                var sum = x + y + carry;

                carry = sum / 10;
                current.List.AddLast(new LinkedListNode<int>(sum % 10));
                current = current.Next;

                p1 = p1?.Next;
                p2 = p2?.Next;
            }

            if (carry>0)
            {
                current.List.AddLast(new LinkedListNode<int>(1));
            }

            return dummyHead.Next;
        }
    }
}
