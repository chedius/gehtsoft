using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tasknew
{
    internal class Program : GeneratedText
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Программа для вывода позиции символа, который нарушает алфавитный порядок");

            //new GeneratedText();
            Console.Write("\nВведите текст: ");
            string txt = Console.ReadLine();
            AlphabetText text = new AlphabetText(txt);
            int i = text.Sort(txt);
            if (i == 0)
            {
                Console.WriteLine("В алфавитном порядке");
            }
            else Console.WriteLine("{0} - первый символ, который нарушает порядок", i);
        }
    }
}
