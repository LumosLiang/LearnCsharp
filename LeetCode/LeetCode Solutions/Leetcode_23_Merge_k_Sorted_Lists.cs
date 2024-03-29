using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_23_Merge_k_Sorted_Lists
    {

        // essentially merge sort
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0) return null;

            return Merge(lists, 0, lists.Length - 1);
        }

        private ListNode Merge(ListNode[] lists, int left, int right)
        {

            if (left == right) return lists[left];

            int mid = left + (right - left) / 2;

            var l = Merge(lists, left, mid);
            var r = Merge(lists, mid + 1, right);

            return Merge(l, r);
        }

        private ListNode Merge(ListNode A, ListNode B)
        {
            if (A == null) return B;
            if (B == null) return A;

            ListNode dummy = new ListNode(0);
            ListNode currA = A, currB = B, curr = dummy;

            while (currA != null && currB != null)
            {
                if (currA.val <= currB.val)
                {
                    curr.next = new ListNode(currA.val);
                    currA = currA.next;
                }
                else 
                {
                    curr.next = new ListNode(currB.val);
                    currB = currB.next;
                }
                curr = curr.next;
            }

            if (currA != null) curr.next = currA;
            else curr.next = currB;

            return dummy.next;
        }


        // another way using heap
        //public ListNode MergeKLists(ListNode[] lists)
        //{

        //    PriorityQueue<ListNode, int> pq = new PriorityQueue<ListNode, int>();

        //    foreach (var head in lists)
        //    {
        //        if (head != null) pq.Enqueue(head, head.val);
        //    }

        //    var res = new ListNode();
        //    var curr = res;

        //    while (pq.Count != 0)
        //    {
        //        var node = pq.Dequeue();
        //        if (node.next != null) pq.Enqueue(node.next, node.next.val);

        //        curr.next = node;
        //        curr = curr.next;
        //        // node.next = null;
        //    }

        //    return res.next;

        //}
    }

}

