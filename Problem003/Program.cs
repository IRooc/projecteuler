/*
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?

*/
Int64 i = 1;
var primeFactors = new List<Int64>();
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
   
   if (isprime && (600851475143 % i == 0)) {
      primeFactors.Add(i);
   }
   Int64 factor = 1;
   foreach(var p in primeFactors){
      factor *= p;
   }
   if (factor == 600851475143) break;
}
Console.WriteLine(string.Join(",",primeFactors.Select(p=>p.ToString())));