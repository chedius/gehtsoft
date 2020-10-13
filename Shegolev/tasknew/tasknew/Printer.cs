using System;
using System.Collections.Generic;
using System.Text;

namespace tasknew
{
    class Printer
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Enter the text by hand");
            Console.WriteLine("2. Enter a prepared text");
            Console.WriteLine("3. Generator of text");
            Console.WriteLine("4. Tests");
            Console.WriteLine("5. Exit");
        }
        public static void EnText()
        {
            Console.WriteLine("Enter the text: ");
        }
        public static void EnAlphabet()
        {
            Console.WriteLine("Enter the alphabet: ");
        }
        public static void EnCountLet()
        {
            Console.WriteLine("Enter count of letters: ");
        }
        public static void GenText(string txt)
        {
            Console.WriteLine("Generated text: {0}", txt);
        }
        public static void Test(int n)
        {
            Console.WriteLine("Test №{0}", n);
        }
        public static void EnCorrValue()
        {
            Console.Clear();
            Console.WriteLine("Enter correct value!");
            Console.ReadKey();
        }
    }
}
