using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Динамический_массив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sum = "sum";
            string exit = "exit";
            string userInput;

            int[] array = new int[0];

            bool exitProgram = true;

            while (exitProgram)
            {
                Console.SetCursorPosition(10, 0);
                Console.WriteLine($"Вы вошли в программу сложения. Поочередно вводите числа.");
                Console.SetCursorPosition(0, 0);
                Console.WriteLine($"\nВведите число:\nВведите {sum} для сложения.\nВведите {exit} для выхода из программы.");
                userInput = Console.ReadLine();

                if (userInput == exit)
                {
                    exitProgram = false;
                    Console.WriteLine($"Вы вышли из программы.");
                }
                else if (userInput == sum)
                {
                    int sumNumbers = 0;

                    for (int i = 0; i < array.Length; i++)
                    {
                        sumNumbers += array[i];
                    }

                    Console.WriteLine($"{sumNumbers} - сумма чисел.");
                }
                else
                {
                    int[] arrayGrowth = new int[array.Length + 1];
                    arrayGrowth[arrayGrowth.Length - 1] = Convert.ToInt32(userInput);

                    for (int i = 0; i < array.Length; i++)
                    {
                        arrayGrowth[i] = array[i];
                    }

                    array = arrayGrowth;
                }
            }

            Console.WriteLine();
        }
    }
}
