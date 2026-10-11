namespace ProverkaZaProstiChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reshenie bez MVC model
            /*
            Console.Write("Enter numbers: ");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int primeCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= numbers[i] - 1; j++)
                {
                    if (numbers[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    primeCount++;
                }
            }
            Console.WriteLine($"Percent of prime numbers in the sequence: {((double)primeCount / numbers.Length * 100):F2}%");
            Console.WriteLine($"Percent of non-prime numbers in the sequence: {((double)(numbers.Length - primeCount) / numbers.Length * 100):F2}%");
            */
            ControlerPrimeNums controler = new ControlerPrimeNums();
            controler.Run();
        }
    }
}
