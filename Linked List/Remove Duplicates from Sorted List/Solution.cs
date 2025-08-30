/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution 
{
    public ListNode DeleteDuplicates(ListNode head) 
    {
        ListNode list = new ListNode(0);
        ListNode current = list;
        List<int> numbers = new List<int>();
        while(head!=null)
        {
            numbers.Add(head.val);
            head = head.next;
        }
        List<int> distinct = numbers.Distinct().ToList();
        foreach(var x in distinct)
        {
            ListNode node = new ListNode(x);
            current.next = node;
            current = current.next;
        }
        return list.next;
    }
}
