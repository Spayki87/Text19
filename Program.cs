using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сдвиг_значений_массива
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            int userInput;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine("\nУкажите значение сдвига массива влево: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            userInput %= numbers.Length;

            for (int j = 0; j < userInput; j++)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    int buffer = numbers[i];
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = buffer;
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
