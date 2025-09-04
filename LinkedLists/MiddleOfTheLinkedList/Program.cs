// Problem 876. Middle of the Linked List
// Link https://leetcode.com/problems/middle-of-the-linked-list/description/
// Difficulty: Easy

class Solution
{
   static void Main(string[] args)
   {
      int[] input = { 1, 2, 3, 4, 5, 6 };

      ListNode head = BuildLinkedList(input);

      ListNode middle = MiddleNodeSolutionOne(head);

      PrintList(middle);
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
   static ListNode MiddleNodeSolutionOne(ListNode head)
   {
      List<ListNode> list = new List<ListNode>();

      int length = 0;

      while (head != null)
      {
         list.Add(head);
         head = head.next;
         length++;
      }

      return list[length / 2];
   }

   static ListNode MiddleNodeSolutionTwo(ListNode head)
   {
      ListNode slow = head;
      ListNode fast = head;

      while (fast != null && fast.next != null)
      {
         slow = slow.next;
         fast = fast.next.next;
      }

      return slow;
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
