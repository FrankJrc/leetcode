using System;
namespace LeetCodeSolution.Solutions
{
    public class SwapNodesInPairSln
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode SwapPairs(ListNode head)
        {
            var res = head;


            ListNode pre = null;
            ListNode current = head;
            ListNode next = head?.next;
            bool isFirst = true;

            while(current!=null && next!=null)
            {
                if(pre!=null)
                {
                    pre.next = next;
                }
                pre = current;
                var tmp = next.next;
                next.next = current;
                current.next = tmp;

                if(isFirst)
                {
                    res = next;
                    isFirst = false;
                }
                current = current.next;
                next = current?.next;
            }


            return res;
        }

    }
}
