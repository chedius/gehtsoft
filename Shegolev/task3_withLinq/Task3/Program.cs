using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Comparator func = new Comparator();
            List<string> list = new List<string>();

            string vbn;
            Console.WriteLine("Введите L:");
            int L = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество желаемых слов:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите слова:");
            for (int i = 0; i < a; i++)
            {
                vbn = Console.ReadLine();
                if (vbn.Length == L)
                {
                    list.Add(vbn);
                }
            }

            string qwerty = func.Compare(list);
            Console.WriteLine(qwerty);
            
        }
    }
}
