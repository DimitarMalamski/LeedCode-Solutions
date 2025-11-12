// Problem 141. Linked List Cycle
// Link https://leetcode.com/problems/linked-list-cycle/description/?envType=problem-list-v2&envId=hash-table
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      ListNode head = new ListNode(3);
      head.next = new ListNode(2);
      head.next.next = new ListNode(0);
      head.next.next.next = new ListNode(-4);
      head.next.next.next.next = head.next;

      bool result = HasCycleHashTable(head);
      Console.WriteLine(result);
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

   public static bool HasCycle(ListNode head)
   {
      ListNode fast = head;

      while (fast != null && fast.next != null)
      {
         head = head.next;
         fast = fast.next.next;

         if (head == fast) return true;
      }

      return false;
   }

   public static bool HasCycleHashTable(ListNode head)
   {
      HashSet<ListNode> seen = new HashSet<ListNode>();

      while (head != null)
      {
         if (seen.Contains(head)) return true;

         seen.Add(head);
         head = head.next;
      }

      return false;
   }
}
