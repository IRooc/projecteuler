/*
By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number?
*/
Int64 i = 1;
var primeCount = 0;
while (true) {
   i++;
   bool isprime = true;
   for (int j = 2; j <= i / 2; j++)
   {
      if (i % j == 0)
      {
         isprime = false;
         break;
      }
   }
   
   if (isprime) {
      primeCount++;
   }
   if (primeCount == 10001) break;
}
Console.WriteLine(i);