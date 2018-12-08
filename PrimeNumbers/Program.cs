using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int xRow = 2; xRow < 100; xRow++)
            {
                int isPrime = 0;
                for (int yRow = 1; yRow < xRow; yRow++)
                {
                    if (xRow % yRow == 0)
                        isPrime++;

                    if (isPrime == 2) break;
                }
                if (isPrime != 2)
                    Console.WriteLine("This is a prime number :" + xRow);

                isPrime = 0;
            }
            Console.ReadKey();
        }
    }
}
