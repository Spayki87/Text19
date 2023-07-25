using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "В этом задании мне все понятно";
            char[] textArray = new char[] { ' ' };

            foreach (string word in text.Split(textArray))
            {
                Console.WriteLine(word);
            }

            Console.WriteLine();
        }
    }
}
