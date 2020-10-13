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
            AlphabetText str = new AlphabetText();
            GenerateText str1 = new GenerateText();
            Tester test = new Tester();
            Generator generator = new Generator();

            while (true) 
            {
                Console.Clear();
                Console.WriteLine("1. Ввести текст вручную");
                Console.WriteLine("2. Ввод заранее подготовленного текста");
                Console.WriteLine("3. Генератор строки");
                Console.WriteLine("4. Тесты");
                Console.WriteLine("5. Выход");
                
                //int i = 0;
                bool testres;
                char key = Console.ReadKey().KeyChar;
                int num;

                switch(key) 
                {
                    case '1': 
                        Console.Clear();
                        Console.Write("Введите текст: ");
                        txt = Console.ReadLine().ToUpper();
                        str.Sort(txt, out num);
                        Console.ReadKey();
                    break;

                    case '2': 
                        Console.Clear();
                        string genStr;
                        //GeneratedText(out genStr);
                        //Console.WriteLine("Заранее созданный текст: " + genStr);
                        str1.GeneratedText(out genStr);
                        Console.ReadKey();
                    break;

                    case '3':
                        Console.Clear();
                        Console.WriteLine("Enter the alphabet: ");
                        string userString = Console.ReadLine();
                        Console.WriteLine("Enter count of letters: ");
                        int letters = Convert.ToInt32(Console.ReadLine());
                        txt = generator.Generation(userString, letters);
                        Console.WriteLine("Generated text: " + txt);
                        str.Sort(txt, out num);
                        Console.ReadKey();
                    break;

                    case '4':
                        Console.Clear();
                        Console.WriteLine("Test №1");
                        testres = test.TestCase1();
                        Console.WriteLine(testres);
                        Console.WriteLine("Test №2");
                        testres = test.TestCase2();
                        Console.WriteLine(testres);
                        Console.WriteLine("Test №3");
                        testres = test.TestCase3();
                        Console.WriteLine(testres);
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
