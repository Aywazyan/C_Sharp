using System;

namespace PrimeFinder
{
    static class PrimeFinder
    {
        static void Main()
        {
            int i = 1;

            while (i < 1000000)
            {
                bool isPrime = true;

                if (i <= 1)
                {
                    isPrime = false;
                }
                else
                {
                    int j = 2;
                    while (j < i)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        j++;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}