// Problem 1768. Merge Strings Alternately
// Link https://leetcode.com/problems/merge-strings-alternately/?envType=study-plan-v2&envId=leetcode-75
// Difficulty: Easy

class Solution
{
   static void Main(string[] args)
   {
      string word1 = "ab";
      string word2 = "pqrs";
      string output = MergeAlternatelySolutionThree(word1, word2);

      Console.WriteLine(output);
   }
   static string MergeAlternately(string word1, string word2)
   {
      if (word1 == "")
      {
         return word2;
      }

      if (word2 == "")
      {
         return word1;
      }

      int pointerOne = 0;
      int pointerTwo = 0;
      string output = "";

      if (word1.Length >= word2.Length)
      {
         while (pointerTwo != word2.Length)
         {
            output += word1[pointerOne];
            output += word2[pointerTwo];

            pointerOne++;
            pointerTwo++;
         }

         while (pointerOne != word1.Length)
         {
            output += word1[pointerOne];
            pointerOne++;
         }
      }
      else
      {
         while (pointerOne != word1.Length)
         {
            output += word1[pointerOne];
            output += word2[pointerTwo];

            pointerOne++;
            pointerTwo++;
         }

         while (pointerTwo != word2.Length)
         {
            output += word2[pointerTwo];
            pointerTwo++;
         }
      }

      return output;
   }
   static string MergeAlternatelySolutionTwo(string word1, string word2)
   {
      int p1 = 0;
      int p2 = 0;
      string result = "";

      while (p1 < word1.Length || p2 < word2.Length)
      {
         if (p1 < word1.Length)
         {
            result += word1[p1];
            p1++;
         }

         if (p2 < word2.Length)
         {
            result += word2[p2];
            p2++;
         }
      }

      return result;
   }

   static string MergeAlternatelySolutionThree(string word1, string word2)
   {
      int l1 = word1.Length, l2 = word2.Length, k = 0;
      char[] buf = new char[l1 + l2];

      int i = 0, j = 0;
      while (i < l1 || j < l2)
      {
         if (i < l1) buf[k++] = word1[i++];
         if (j < l2) buf[k++] = word2[j++];
      }

      return new string(buf);
   }
}
