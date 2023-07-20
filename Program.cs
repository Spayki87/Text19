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
            int[,] A = new int[lineSize, columnSize];
            int maxElement = int.MinValue;
            int minValue = 0;
            int maxValue = 50;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = random.Next(minValue, maxValue);
                    Console.Write(A[i, j] + "  ");

                    if (maxElement < A[i, j])
                    {
                        maxElement = A[i, j];
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine($"\nМаксимальное число массива: {maxElement}\n");

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (maxElement == A[i, j])
                    {
                        A[i, j] = 0;

                        if (A[i, j] == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.Write(A[i, j] + "  ");
                }

                Console.WriteLine();
            }
        }
    }
}
