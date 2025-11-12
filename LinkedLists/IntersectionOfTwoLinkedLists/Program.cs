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
      ListNode intersectionNode = solution.GetIntersectionNodeHashTable(headA, headB);
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

   public ListNode GetIntersectionNodeHashTable(ListNode headA, ListNode headB)
   {
      if (headA == null || headB == null) return null;

      HashSet<ListNode> seen = new HashSet<ListNode>();

      while (headA != null)
      {
         seen.Add(headA);
         headA = headA.next;
      }

      while (headB != null)
      {
         if (seen.Contains(headB)) return headB;
         headB = headB.next;
      }

      return null;
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
