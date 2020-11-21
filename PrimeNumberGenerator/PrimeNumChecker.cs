using System;

namespace PrimeNumberGenerator
{
    public static class PrimeNumChecker
    {
        public static bool IsPrimeByRabinMiller(int number)
        {
            int s = 0;
            int t = 0;
            int a = 0;
            int i;

            // Цикл, в котором подбирается случайное число 'a' и параметры для 'n' (number)
            for (i = 0; i < number * 2; i++)
            {
                Random random = new Random();
                a = random.Next(2, number - 1);

                if (GCF(a, number) != 1)
                {
                    return false;
                }

                for (i = 0; i < 30; i++)
                {
                    int pow = Convert.ToInt32(Math.Pow(2, i));

                    if (pow >= (number - 1) / 2)
                    {
                        break;
                    }

                    if ((number - 1) % pow == 0)
                    {
                        t = (number - 1) / pow;
                        s = i;
                    }
                }

                // Если параметры не подобрались
                if (t == 0)
                {
                    continue;
                }

                // Расчитываем 'z'
                long z = 1;
                for (i = 0; i < t; i++)
                {
                    z = (z * a) % number;
                }

                // Первая проверка условия простоты
                if ((z % number) != 1 && (z % number) != (number - 1))
                {
                    break;
                }
            }

            // Если слишком много раз неподбирались параметры
            if (i == number * 2)
            {
                return false;
            }

            // Цикл для второй проверки второго условия простоты
            for (i = 0; i < s; i++)
            {
                long exp = Convert.ToInt64(Math.Pow(2, i)) * t;
                long at = a;
                long tmp = 1;
                for (int j = 0; j < exp; j++)
                {
                    tmp = (tmp * at) % number;
                }
                at = tmp;

                if ((at % number) == 1 || (at % number) == (number - 1))
                {
                    break;
                }
            }
            if (i == s)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool IsPrime(int number)
        {
            int accuracy = number;
            if ((number < 2) || (number % 2 == 0))
                return false;

            int s = number - 1;
            while (s % 2 == 0) 
                s >>= 1;

            Random random = new Random();
            for (int i = 0; i < accuracy; i++)
            {
                int a = random.Next(number - 1) + 1;
                int temp = s;
                long mod = 1;
                for (int j = 0; j < temp; ++j)
                {
                    mod = (mod * a) % number;
                }
                while (temp != number - 1 && mod != 1 && mod != number - 1)
                {
                    mod = (mod * mod) % number;
                    temp *= 2;
                }

                if (mod != number - 1 && temp % 2 == 0)
                    return false;
            }

            return true;
        }

        private static int GCF(int a, int b)// Greatest common factor (НОД)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }
    }
}
