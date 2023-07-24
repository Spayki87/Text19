using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сортировка_чисел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 2, 14, 5, 6, 81, 9, 51, 1, 27 };
            int tempNumber;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        tempNumber = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = tempNumber;
                    }
                }

                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
