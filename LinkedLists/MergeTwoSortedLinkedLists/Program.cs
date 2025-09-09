// Problem 21. Merge Two Sorted Lists
// Link https://leetcode.com/problems/merge-two-sorted-lists/description/
// Difficulty: Easy

class Solution
{
   static void Main(string[] args)
   {
      int[] listOne = { 1, 2, 4 };
      int[] listTwo = { 1, 3, 5 };

      ListNode headOne = BuildLinkedList(listOne);
      ListNode headTwo = BuildLinkedList(listTwo);

      ListNode mergedList = MergeTwoLists(headOne, headTwo);

      PrintList(mergedList);
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
   static ListNode RecursiveMergeTwoLists(ListNode list1, ListNode list2)
   {
      if (list1 == null)
      {
         return list2;
      }

      if (list2 == null)
      {
         return list1;
      }

      if (list1.val <= list2.val)
      {
         list1.next = RecursiveMergeTwoLists(list1.next, list2);
         return list1;
      }
      else
      {
         list2.next = RecursiveMergeTwoLists(list1, list2.next);
         return list2;
      }
   }

   static ListNode MergeTwoLists(ListNode list1, ListNode list2)
   {
      ListNode dummy = new ListNode(0);
      ListNode node = dummy;

      while (list1 != null && list2 != null)
      {
         if (list1.val < list2.val)
         {
            node.next = list1;
            list1 = list1.next;
         }
         else
         {
            node.next = list2;
            list2 = list2.next;
         }

         node = node.next;
      }

      if (list1 != null)
      {
         node.next = list1;
      }
      else
      {
         node.next = list2;
      }

      return dummy.next;
   }
}
