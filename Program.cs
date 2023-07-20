using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Локальные_максимумы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int arrayElements = 30;
            int[] arrayNumbers = new int[] { 6, 16, 83, 82, 7, 68 };
            int minValue = 0;
            int maxValue = 100;

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
               // arrayNumbers[i] = random.Next(minValue, maxValue);
                Console.Write(arrayNumbers[i] + " ");
            }

            if (arrayNumbers[0] > arrayNumbers[1])
            {
                Console.WriteLine(arrayNumbers[0]);
            }

            for (int i = 1; i < arrayNumbers.Length - 2; i++)
            {
                if (arrayNumbers[i] > arrayNumbers[i + 1] && arrayNumbers[i] > arrayNumbers[i - 1])
                {
                    Console.WriteLine(arrayNumbers[i]);
                }
            }

            //if (arrayNumbers[arrayElements - 1])
            //Console.WriteLine(arrayNumbers[arrayElements - 1] + " ");

        }
    }
}
