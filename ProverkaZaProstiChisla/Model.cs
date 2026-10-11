using System;
using System.Collections.Generic;
using System.Text;

namespace ProverkaZaProstiChisla
{
    public class Model
    {
        public int[] Numbers { get; set; }
        public int PrimeCount { get; set; }
        public int CalculatePrimeCount()
        {
            PrimeCount = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Numbers[i] - 1; j++)
                {
                    if (Numbers[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    PrimeCount++;
                }
            }
            return PrimeCount;
        }
    }
}
