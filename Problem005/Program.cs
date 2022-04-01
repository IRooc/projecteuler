/*
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*/

Int64 max = 1;
for (int i = 1; i <= 20; i++)
{
   max *= i;
}
Console.WriteLine("Max number " + max);
Int64 cur = 20;
while (cur < max)
{
   bool success = true;
   for (int i = 1; i <= 20; i++)
   {
      if (cur % i != 0)
      {
         success = false;
         break;
      }
   }
   if (success){
      Console.WriteLine(cur);
      break;
   }

   cur++;
}