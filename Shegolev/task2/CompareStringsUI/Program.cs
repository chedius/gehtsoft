using System;
using CompareStringsLib;

namespace CompareStringsUI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string asd = ""; 
            Compare qwe = new Compare();
            Console.WriteLine("Enter lenght of strings:");
            int L = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter strings. If you want to finish typing, press Esc.");
            string str = Console.ReadLine();

            qwe.Sort(str);
        }
    }
}
