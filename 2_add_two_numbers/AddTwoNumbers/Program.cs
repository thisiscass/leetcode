using System;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
            Example 3:

            Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
            Output: [8,9,9,9,0,0,0,1]

            l1 = 9999999
            l2 = 0009999
        
        */

        var l1 = new ListNode(9);
        var l2 = new ListNode(9, l1);
        var l3 = new ListNode(9, l2);
        var l4 = new ListNode(9, l3);
        var l5 = new ListNode(9, l4);
        var l6 = new ListNode(9, l5);
        var l7 = new ListNode(9, l6);

        // l1.next = l2;
        // l2.next = l3;
        // l3.next = l4;
        // l4.next = l5;
        // l5.next = l6;
        // l6.next = l7;

        var secondl1 = new ListNode(9);
        var secondl2 = new ListNode(9, secondl1);
        var secondl3 = new ListNode(9, secondl2);
        var secondl4 = new ListNode(9, secondl3);

        // secondl1.next = secondl2;
        // secondl2.next = secondl3;
        // secondl3.next = secondl4;


        var solution = new Solution();

        // var l1 = new ListNode(3);
        // var l1Next = new ListNode(4, l1);
        // var l1Last = new ListNode(2, l1Next);

        // var l2 = new ListNode(4);
        // var l2next = new ListNode(6, l2);
        // var l2last = new ListNode(5, l2next);

        var result = solution.AddTwoNumbers(l7, secondl4);

        while(result != null)
        {
            Console.WriteLine(result.val + "->");
            result = result.next;
        }
    }
}