using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalNumsLib
{
    public static class NaturalNumbers
    {

        public static bool IsEven(int Number)
        {
            return Number % 2 == 0;
        }

        /// <summary>
        /// Вычисляет НОД для двух целых положительных чисел
        /// </summary>
        /// <param name="A">Первое число</param>
        /// <param name="B">Второе число</param>
        /// <returns>Возвращает значение НОД</returns>
        public static int GCD(int A, int B) // greatest common divisor (GCD)
        {
            while (B != 0)
            {
                int temp = B;
                B = A % B;
                A = temp;
            }
            return A;
        }
        public static bool IsPrime(int number)
        {
            // Простые числа меньше или равны 1 не являются простыми.
            if (number <= 1)
            {
                return false;
            }

            // 2 - единственное четное простое число.
            if (number <= 3)
            {
                return true;
            }

            // Числа, кратные 2 или 3, не являются простыми.
            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }

            // Проверка делителей до квадратного корня из числа.  Это существенно повышает эффективность.
            for (int i = 5; i * i <= number; i = i + 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static int LCM(int a, int b)
        {
            // Обработка нулей. НОК(a, 0) = 0 и НОК(0, b) = 0
            if (a == 0 || b == 0) return 0;

            // Найдем большее число
            int max = Math.Max(a, b);
            int lcm = max;

            while (true)
            {
                if (lcm % a == 0 && lcm % b == 0)
                {
                    return lcm;
                }
                lcm += max;
            }
        }
    }
}
