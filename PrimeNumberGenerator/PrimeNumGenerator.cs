namespace PrimeNumberGenerator
{
    public static class PrimeNumGenerator
    {
        public static int Generate(int min, int max, out int iterationCount)
        {
            int generatedNumber;
            bool isPrime;
            iterationCount = 0;

            do
            {
                generatedNumber = OddNumberGenerator.Generate(min, max);
                isPrime = PrimeNumChecker.IsPrime(generatedNumber);

                iterationCount++;
            }
            while (!isPrime);

            return generatedNumber;
        }
    }
}
