using System.Collections.Generic;
using System.Linq;

namespace AlgoPrac.Problems
{
    public static class MergeTwoSortedLinkedLists
    {
        // TODO: Finish this off
        public static ListNode MergeSolution(ListNode l1, ListNode l2)
        {
            var v1 = new List<int>();
            while (l1?.next != null || l1?.val < int.MaxValue)
            {
                v1.Add(l1.val);
                l1 = l1.next;
            }

            var v2 = new List<int>();
            while (l2?.next != null || l1?.val < int.MaxValue)
            {
                v2.Add(l2.val);
                l2 = l2.next;
            }

            var v3 = v1.Concat(v2).OrderBy(x => x).ToList();

            // Not working need to look at proper ways to merge linked lists
            ListNode r = new ListNode(v3[0]);
            ListNode last = r.next;
            for (var i = 0; i < v3.Count; i++)
            {
                last.next = new ListNode(v3[i]);
            }

            return r;
        }
    }

    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }
}
