using System;

namespace ClassTable
{
    //Вывод текстового меню
    class TextPrinter
    {
        public static void MainMenu()
        {
            Console.WriteLine("Choose one of the following actions: \n1.Hexadecimal multiplication table output \n2.Random array output \n3.Exit");
        }

        public static void Dimensity()
        {
            Console.WriteLine("Please enter dimensity of the array:");
        }

        public static void Default()
        {
            Console.WriteLine("Please enter number of action");
        }
    }
}
