using System;
using System.Linq;

namespace LinqUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input char");
            char C = Console.ReadKey().KeyChar;
            Console.WriteLine("Input string");
            string A = Console.ReadLine();
            int SumLong = 0;

            string[] words = A.Split(new char[] { C }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length > 1)
            {
                for (int i = 1; i < words.Length - 1; i++)
                {
                    SumLong += words[i].Length;
                }
                Console.WriteLine("Колличество элементов {0}" ,words.Length - 2);
                Console.WriteLine("Сумма длинн строк {0}", SumLong);
                
            }
            else
            {
                Console.WriteLine(words.Length);
            }
            
        }
    }
}
