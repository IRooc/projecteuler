/*
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.
*/
var largest = 0;
for (int i = 999; i >= 100; i--)
{
   for (int j = 999; j >= 100; j--)
   {
      var product = (i * j).ToString();
      if (product[0] != product[product.Length-1]) continue;
      var start = 0;
      var end = product.Length - 1;
      var palindrome = true;
      while (start < end)
      {
         if (product[start] != product[end])
         {
            palindrome = false;
            break;
         }
         start++;
         end--;
      }
      if (palindrome)
      {
         largest = Math.Max(largest, (i*j));
      }
   }
}
Console.WriteLine("Largest " + largest);