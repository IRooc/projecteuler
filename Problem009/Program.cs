/*
A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

a2 + b2 = c2
For example, 32 + 42 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.

*/
var found = false;
for (int a = 1; a < 500; a++)
{
   for (int b = 1; b < 500; b++)
   {
      for (int c = 1; c < 500; c++)
      {
         if (a + b + c == 1000)
         {
            if (a * a + b * b == c * c)
            {
               Console.WriteLine($"Found Pythagorean {a} {b} {c}");
               Console.WriteLine($"Found Product {a*b*c}");
               found = true;
               break;
            }
         }
      }
      if (found) break;
   }
   if (found) break;
}