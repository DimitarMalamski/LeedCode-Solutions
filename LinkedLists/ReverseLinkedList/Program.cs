// Problem 206. Reverse Linked List
// Link https://leetcode.com/problems/reverse-linked-list/description/
// Difficulty: Easy

class Solution
{
   static void Main(string[] args)
   {
      int[] input = { 1, 2, 3, 4 };

      ListNode head = BuildLinkedList(input);

      ListNode reversed = RecursiveReverseLinkedList(head);

      PrintList(reversed);
   }

   static ListNode RecursiveReverseLinkedList(ListNode head)
   {
      if (head == null || head.next == null)
      {
         return head;
      }

      ListNode newHead = RecursiveReverseLinkedList(head.next);

      head.next.next = head;
      head.next = null;

      return newHead;
   }
   static ListNode ReverseLinkedList(ListNode head)
   {
      ListNode prev = null;
      ListNode current = head;

      while (current != null)
      {
         ListNode next = current.next;
         current.next = prev;
         prev = current;
         current = next;
      }

      return prev;
   }
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

   static ListNode BuildLinkedList(int[] nums)
   {
      if (nums.Length == 0) return null;

      ListNode head = new ListNode(nums[0]);
      ListNode current = head;

      for (int i = 1; i < nums.Length; i++)
      {
         current.next = new ListNode(nums[i]);
         current = current.next;
      }

      return head;
   }

   static void PrintList(ListNode node)
   {
      while (node != null)
      {
         Console.Write(node.val + ",");
         node = node.next;
      }

      Console.WriteLine();
   }
}
