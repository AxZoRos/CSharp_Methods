using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB11_KTP
{
    internal class Program
    {
        // Допоміжний метод для перевірки: чи є число простим.
        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            int boundary = (int)Math.Sqrt(number);
            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        // Метод для підрахунку простих чисел у масиві.
        static void CountPrimes(int[] numbers, out int primeCount)
        {
            primeCount = 0;
            foreach (int num in numbers)
            {
                if (IsPrime(num))
                {
                    primeCount++;
                }
            }
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть кількість чисел у масиві:");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int n);
            if (!isValidInput || n <= 0)
            {
                Console.WriteLine("Будь ласка, введіть допустиме позитивне ціле число.");
                return;
            }
            int[] arr = new int[n];
            // Введення чисел у масив
            Console.WriteLine("Введіть числа:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Число {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Оголошення змінної для підрахунку простих чисел
            int countPrimes;
            CountPrimes(arr, out countPrimes);
            Console.WriteLine("Кількість простих чисел у масиві: " + countPrimes);
            Console.WriteLine("Масив чисел: " + string.Join(", ", arr));
            Console.ReadLine();
        }

    }
}
