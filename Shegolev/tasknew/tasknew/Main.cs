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

            while (true) 
            {
                Console.Clear();
                Console.WriteLine("1. Ввести текст вручную");
                Console.WriteLine("2. Ввод заранее подготовленного текста");
                Console.WriteLine("3. Тестинг программы");
                Console.WriteLine("4. Выход");
                
                GenerateText asd = new GenerateText();
                int i;
                int key = Convert.ToInt32(Console.ReadLine());
                switch(key) 
                {
                    case 1: 
                    
                        Console.Clear();
                        Console.Write("\nВведите текст: ");
                        string txt = Console.ReadLine();
                        AlphabetText text1 = new AlphabetText(txt);
                        i = text1.Sort(txt);
                        if (i == 0)
                        {
                            Console.WriteLine("В алфавитном порядке");
                        }
                        else Console.WriteLine("{0} - первый символ, который нарушает порядок", i); //Подсчет символов начинается с нуля почему то
                        Console.ReadKey();
                    break;

                    case 2: 
                    {
                        Console.Clear();
                        string str = "АБВГДЕЖАВГ.";
                        Console.WriteLine("Исходный текст: " + str);
                        AlphabetText text2 = new AlphabetText(str);
                        i = asd.GeneratedText(str);
                        if (i == 0)
                        {
                            Console.WriteLine("В алфавитном порядке");
                        }
                        else Console.WriteLine("{0} - первый символ, который нарушает порядок", i);
                        Console.ReadKey();
                    }
                    break;

                    case 3: {}
                    break;

                    case 4: 
                    {
                        Environment.Exit(0);
                        break;
                    }
                }
            }
        }
    }
}
