using System;
namespace LeetCodeSolution.Solutions
{
    public class MergeTwoSortedListsSln
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            ListNode res = null;
            ListNode iterator = null;
            if(l1.val<=l2.val)
            {
                res = iterator = l1;
                l1 = l1.next;
            }
            else
            {
                res = iterator = l2;
                l2 = l2.next;
            }
            while(l1!=null || l2!=null)
            {
                if(l1==null)
                {
                    iterator.next = l2;
                    break;
                }
                if(l2==null)
                {
                    iterator.next = l1;
                    break;
                }
                //l1 and l2 not null
                if(l1.val<=l2.val)
                {
                    iterator.next = l1;
                    iterator = iterator.next;
                    l1 = l1.next;
                }
                else
                {
                    iterator.next = l2;
                    iterator = iterator.next;
                    l2 = l2.next;
                }
            }
            return res;
        }
    }
}
