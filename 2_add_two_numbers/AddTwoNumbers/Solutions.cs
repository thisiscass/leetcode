
//Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        return Sum(l1, l2, 0);
    }

    public ListNode Sum(ListNode? l1, ListNode? l2, int over)
    {
        if (l1 == null && l2 == null && over == 0)
        {
            return null;
        }

        int l1Val = 0;
        int l2Val = 0;

        if (l1 != null)
        {
            l1Val = l1.val;
        }

        if (l2 != null)
        {
            l2Val = l2.val;
        }

        int currentSum = l1Val + l2Val + over;

        over = currentSum / 10;
        int result = currentSum % 10;

        var node = new ListNode(result);
        node.next = Sum(l1?.next, l2?.next, over);

        return node;
    }
}