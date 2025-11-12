// Problem 160. Intersection of Two Linked Lists
// Link https://leetcode.com/problems/intersection-of-two-linked-lists/description/?envType=problem-list-v2&envId=hash-table
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      ListNode intersect = new ListNode(8, new ListNode(4, new ListNode(5)));

      ListNode headA = new ListNode(4, new ListNode(1, intersect));
      ListNode headB = new ListNode(5, new ListNode(6, new ListNode(1, intersect)));

      Solution solution = new Solution();
      ListNode intersectionNode = solution.GetIntersectionNode(headA, headB);
      Console.WriteLine(intersectionNode == null ? "null" : intersectionNode.val);
   }

   public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
   {
      if (headA == null || headB == null) return null;

      ListNode a = headA;
      ListNode b = headB;

      while (a != b)
      {
         a = (a == null) ? headB : a.next;
         b = (b == null) ? headA : b.next;
      }

      return a;
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
}
