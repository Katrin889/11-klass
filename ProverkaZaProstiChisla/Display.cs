using System;
using System.Collections.Generic;
using System.Text;

namespace ProverkaZaProstiChisla
{
    public class Display
    {
        private int[] numbers;
        private int primeCount;
        public int[] Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }
        public int PrimeCount
        {
            get { return primeCount; }
            set { primeCount = value; }
        }
        public Display(int[] numbers, int primeCount)
        {
            this.numbers = numbers;
            this.primeCount = primeCount;
        }
        public Display(): this(new int[0], 0) { }
        public void InputNumbers()
        {
            Console.Write("Enter numbers: ");
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
        public void DisplayResults()
        {
            Console.WriteLine($"Percent of prime numbers in the sequence: {((double)primeCount / numbers.Length * 100):F2}%");
            Console.WriteLine($"Percent of non-prime numbers in the sequence: {((double)(numbers.Length - primeCount) / numbers.Length * 100):F2}%");
        }
    }
}
