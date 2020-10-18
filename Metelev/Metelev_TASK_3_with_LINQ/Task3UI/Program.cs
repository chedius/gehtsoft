using System;
using System.Collections.Generic;

namespace Task3UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Reverser rvr = new Reverser();
            Console.WriteLine("Enter the number of strings");
            int num = Convert.ToInt32(Console.ReadLine());
            string str;
            List<string> strList = new List<string>();
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("\nEnter string number " + i);
                str = Console.ReadLine();
                strList.Add(str);
            }
            string s = rvr.ReverseOrder(num, strList);
            Console.WriteLine("\nFirst characters of each line in reverse order: " + s);

        }
    }
}
