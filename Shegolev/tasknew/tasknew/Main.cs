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

            while (true) 
            {
                Console.Clear();
                Console.WriteLine("1. Ввести текст вручную");
                Console.WriteLine("2. Ввод заранее подготовленного текста");
                Console.WriteLine("3. Генератор строки");
                Console.WriteLine("4. Тесты");
                Console.WriteLine("5. Выход");
                
                GenerateText asd = new GenerateText();
                int i;
                char key = Console.ReadKey().KeyChar;

                switch(key) 
                {
                    case '1': 
                        Console.Clear();
                        Console.Write("Введите текст: ");
                        string txt = Console.ReadLine().ToUpper();
                        AlphabetText text1 = new AlphabetText(txt);
                        i = text1.Sort(txt);
                        if (i == 0)
                        {
                            Console.WriteLine("В алфавитном порядке");
                        }
                        else Console.WriteLine("{0} - первый символ, который нарушает порядок", i);
                        Console.ReadKey();
                    break;

                    case '2': 
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
                    break;

                    case '3': 
                        Console.Clear();
                        Console.WriteLine("Введите алфавит.");
                        string setUserStr = Console.ReadLine();
                        char[] setUserSymbols = setUserStr.ToUpper().ToCharArray();
                        Generator generator = new Generator(setUserSymbols);

                        Console.Write("Введите количество букв в слове: ");
                        int letters = Convert.ToInt32(Console.ReadLine());
                        string stringg = generator.Generation(letters);

                        Console.WriteLine("Сгенерированный текст: " + stringg);
                        AlphabetText text3 = new AlphabetText(stringg);
                        i = text3.Sort(stringg);
                        if (i == 0)
                        {
                            Console.WriteLine("В алфавитном порядке");
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
