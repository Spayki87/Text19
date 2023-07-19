using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа_с_конкретными_строками__столбцами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lineSize = 4;
            int columnSize = 4;

            int[,] array = new int[lineSize, columnSize];
            Random random = new Random();

            int sum = 0;
            int product = 1;
            int lineNumber = 2;
            int columnNumber = 1;
            int minNumber = 1;
            int maxNumber = 4;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minNumber, maxNumber);
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(1); i++)
            {
                sum += array[lineNumber - 1, i];
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                product *= array[i, columnNumber - 1];
            }

            Console.WriteLine($"{sum} - сумма чисел {lineNumber} строки.");
            Console.WriteLine($"{product} - произведение чисел {columnNumber} столбца.");
        }
    }
}
