using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подмассив_повторений_чисел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 30;
            int[] numbers = new int[arrayLength];

            Random random = new Random();

            int minNumber = 1;
            int maxNumber = 3;
            int counter = 1;
            int maxRepeats = 1;
            int number = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minNumber, maxNumber);
                Console.Write($"{numbers[i]} ");
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter > maxRepeats)
                {
                    maxRepeats = counter;
                    number = numbers[i];
                }
            }

            if (number == 0)
            {
                Console.WriteLine($"Нет чисел повторяющихся подряд.");
            }

            Console.WriteLine();
            Console.WriteLine($"Число {number} повторяется наибольшее количество раз подряд: {maxRepeats}.");
        }
    }
}
