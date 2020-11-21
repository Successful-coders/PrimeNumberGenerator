using System;

namespace PrimeNumberGenerator
{
    public static class OddNumberGenerator
    {
        public static int Generate(int min, int max)
        {
            Random random = new Random();
            int generatedNumber;

            do
            {
                generatedNumber = random.Next(min, max);
            }
            while (generatedNumber % 2 == 0);

            return generatedNumber;
        }
    }
}
