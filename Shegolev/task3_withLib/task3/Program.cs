using System;
using System.Collections.Generic;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Comparator func = new Comparator();
            string qwe = "";

            Console.WriteLine("Введите L:");
            int L = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество желаемых слов:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите слова:");
            string qwerty = func.Compare(L, a, qwe);
            Console.WriteLine("Наибольшая строка: " + qwerty);
        }
    }
}
