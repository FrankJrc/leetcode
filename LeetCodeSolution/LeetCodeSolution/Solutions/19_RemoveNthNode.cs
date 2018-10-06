using System;
using System.Collections.Generic;
namespace LeetCodeSolution.Solutions
{
    public class RemoveNthNode
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null)
                return null;

            List<ListNode> nodes = new List<ListNode>();
            while(head!=null)
            {
                nodes.Add(head);
                head = head.next;
            }
            if(n==nodes.Count)
            {
                if (nodes.Count == 1) return null;
                return nodes[1];
            }

            if(n==1)
            {
                nodes[nodes.Count - 2].next = null;
                return nodes[0];
            }

            nodes[nodes.Count - n - 1].next = nodes[nodes.Count - n + 1];
            return nodes[0];
        }
    }
}
