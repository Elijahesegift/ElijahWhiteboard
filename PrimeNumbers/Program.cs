using System;

namespace PrimeNumbers
{
    public class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(11));
        }
        public static int PrimeSum(int n)
        {
            int sumOfPrimes = 0;
            int numberOfPrimes = 0;

            int nextInteger = 2;
            while (numberOfPrimes < n)
            {
                if (IsPrime(nextInteger))
                {
                    sumOfPrimes += nextInteger;
                    numberOfPrimes++;
                }
                nextInteger++;
            }

            return sumOfPrimes;
        }
        public static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
