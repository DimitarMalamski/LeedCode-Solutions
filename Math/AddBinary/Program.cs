// Problem 67. Add Binary
// Link https://leetcode.com/problems/add-binary/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string a = "11";
      string b = "1";
      string output = AddBinary(a, b);
      Console.WriteLine(output);
   }
   public static string AddBinary(string a, string b)
   {
      string result = "";
      int carry = 0;

      int i = a.Length - 1;
      int j = b.Length - 1;

      while (i >= 0 || j >= 0 || carry > 0)
      {
         int bitA = i >= 0 ? a[i] - '0' : 0;
         int bitB = j >= 0 ? b[j] - '0' : 0;

         int total = bitA + bitB + carry;
         carry = total / 2;
         result += (total % 2).ToString();

         i--;
         j--;
      }

      char[] final = result.ToCharArray();
      Array.Reverse(final);
      return new string(final);
   } 
}