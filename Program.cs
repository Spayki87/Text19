using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наибольший_элемент
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int lineSize = 10;
            int columnSize = 10;
            int[,] array = new int[lineSize, columnSize];
            int maxElement = int.MinValue;
            int minValue = 0;
            int maxValue = 50;
            int assignedValue = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minValue, maxValue);
                    Console.Write(array[i, j] + "  ");

                    if (maxElement < array[i, j])
                    {
                        maxElement = array[i, j];
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine($"\nМаксимальное число массива: {maxElement}\n");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (maxElement == array[i, j])
                    {
                        array[i, j] = assignedValue;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.Write(array[i, j] + "  ");
                }

                Console.WriteLine();
            }
        }
    }
}
