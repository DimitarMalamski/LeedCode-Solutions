// Problem 345. Reverse Vowels of a String
// Link https://leetcode.com/problems/reverse-vowels-of-a-string/description/?envType=study-plan-v2&envId=leetcode-75
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string s = "IceCreAm";
      string output = ReverseVowels(s);
      Console.WriteLine(output);
   }
   static string ReverseVowels(string s)
   {
      int left = 0;
      int right = s.Length - 1;

      char[] result = s.ToCharArray();

      while (left < right)
      {
         if (!IsVowel(result[left]))
         {
            left++;
         }
         else if (!IsVowel(result[right]))
         {
            right--;
         }
         else
         {
            char temp = result[left];
            result[left] = result[right];
            result[right] = temp;
            left++;
            right--;
         }
      }

      return new string(result);
   }
   static bool IsVowel(char c) {
      return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
         || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
   }
}
