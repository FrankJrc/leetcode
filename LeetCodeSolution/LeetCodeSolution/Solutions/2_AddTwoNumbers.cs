using System;
namespace LeetCodeSolution.Solutions
{


    public class AddTwoNumbers
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode Solve(ListNode l1, ListNode l2) 
        {
			if(l1 == null) return l2;
			if(l2 == null) return l1;
          
			bool first = true;
			ListNode mover=null;
			ListNode res=null;
			bool moreThan10 = false;
			while(l1!=null && l2!=null)
            {
				var sum = moreThan10 ? l1.val+l2.val+1 : l1.val+l2.val;
				if(sum>=10) 
				{
					moreThan10 = true;
					sum = sum % 10;
				}
                else
                {
					moreThan10 = false;
				}
				if(first) 
				{
					res = new ListNode(sum);
					mover = res;
				}
                else 
                {
					var next = new ListNode(sum);
					mover.next = next;
					mover = next;
				}
				first = false;
				l1 = l1.next;
				l2 = l2.next;
			}

			if(l1==null && l2==null)
            {
				if(moreThan10)
                {
					mover.next = new ListNode(1);
				}
				return res;
			}

			if(l1!=null)
            {
				while(l1!=null)
                {
					int s = moreThan10 ? 1+l1.val:l1.val;
					if(s>=10)
                    {
						moreThan10=true;
						var next = new ListNode(s%10);
						mover.next = next;
						mover = next;
					}
                    else
                    {
						moreThan10 = false;
						var next = new ListNode(s);
						mover.next = next;
						mover = next;
					}
					l1 = l1.next;
				}
                if(moreThan10)
                {
                    mover.next = new ListNode(1);
					return res;
                }
			}
			else if(l2!=null)
            {
                while(l2!=null)
                {
                    int s = moreThan10 ? 1+l2.val:l2.val;
                    if(s>=10)
                    {
                        moreThan10=true;
                        var next = new ListNode(s%10);
                        mover.next = next;
                        mover = next;
                    }
                    else
                    {
                        moreThan10 = false;
                        var next = new ListNode(s);
                        mover.next = next;
                        mover = next;
                    }
                    l2 = l2.next;
                }
                if(moreThan10)
                {
                    mover.next = new ListNode(1);
                    return res;
                }
			}
			return res;
		}
	}
}
