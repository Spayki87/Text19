using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "В этом задании мне все понятно-непонятно, но интерестно.";
            char[] delimiters = new char[] { ',', ' ', '-', '.' };
            string[] splitted = text.Split(delimiters);

            foreach (string word in splitted)
            {
                Console.WriteLine(word);
            }

            Console.ReadKey();
        }
    }
}
