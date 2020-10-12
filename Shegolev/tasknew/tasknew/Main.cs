using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tasknew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Программа для вывода позиции символа, который нарушает алфавитный порядок");
            string txt = "";
            //char[] alphabet = null;
            AlphabetText str = new AlphabetText(txt);
            GenerateText str1 = new GenerateText();
            //Generator generator = new Generator(alphabet);
            //Generator generator = new Generator(setUserSymbols);

            while (true) 
            {
                Console.Clear();
                Console.WriteLine("1. Ввести текст вручную");
                Console.WriteLine("2. Ввод заранее подготовленного текста");
                Console.WriteLine("3. Генератор строки");
                Console.WriteLine("4. Тесты");
                Console.WriteLine("5. Выход");
                
                int i;
                char key = Console.ReadKey().KeyChar;

                switch(key) 
                {
                    case '1': 
                        Console.Clear();
                        Console.Write("Введите текст: ");
                        txt = Console.ReadLine().ToUpper();
                        i = str.Sort(txt);
                        if (i == 0)
                        {
                            Console.WriteLine("Текст в алфавитном порядке");
                        }
                        else Console.WriteLine("{0} - первый символ, который нарушает порядок", i);
                        Console.ReadKey();
                    break;

                    case '2': 
                        Console.Clear();
                        txt = "АБВГДЕЖАВГ.";
                        Console.WriteLine("Исходный текст: " + txt);
                        i = str1.GeneratedText(txt);
                        if (i == 0)
                        {
                            Console.WriteLine("Текст в алфавитном порядке");
                        }
                        else Console.WriteLine("{0} - первый символ, который нарушает порядок", i);
                        Console.ReadKey();
                    break;

                    case '3': 
                        Console.Clear();
                        Console.WriteLine("Введите алфавит.");
                        string setUserStr = Console.ReadLine();
                        char[] setUserSymbols = setUserStr.ToUpper().ToCharArray();
                        Generator generator = new Generator(setUserSymbols);

                        Console.Write("Введите количество букв в слове: ");
                        int letters = Convert.ToInt32(Console.ReadLine());
                        txt = generator.Generation(letters);

                        Console.WriteLine("Сгенерированный текст: " + txt);
                        i = str.Sort(txt);
                        if (i == 0)
                        {
                            Console.WriteLine("Текст в алфавитном порядке");
                        }
                        else Console.WriteLine("{0} - первый символ, который нарушает порядок", i);
                        Console.ReadKey();
                    break;

                    case '4':
                        Console.Clear();
                        Tests.TestCase1();
                        Tests.TestCase2();
                        Console.ReadKey();
                        break;

                    case '5': 
                        Environment.Exit(0);
                    break;   

                    default:
                    Console.Clear();
                    Console.WriteLine("Введите корректное значение!");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
