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
            string txt = "";
            AlphabetText str = new AlphabetText();
            GenerateText str1 = new GenerateText();
            Tester test = new Tester();
            Generator generator = new Generator();

            while (true) 
            {
                Printer.Menu();
                
                //int i = 0;
                bool testres;
                char key = Console.ReadKey().KeyChar;
                int num;

                switch(key) 
                {
                    case '1':
                        Printer.EnText();
                        txt = Console.ReadLine().ToUpper();
                        str.Sort(txt, out num);
                        Console.ReadKey();
                    break;

                    case '2': 
                        Console.Clear();
                        string genStr;
                        //GeneratedText(out genStr);
                        //Console.WriteLine("Prepared text: " + genStr);
                        str1.GeneratedText(out genStr);
                        Console.ReadKey();
                    break;

                    case '3':
                        Console.Clear();
                        Printer.EnAlphabet();
                        string userString = Console.ReadLine();
                        Printer.EnCountLet();
                        int letters = Convert.ToInt32(Console.ReadLine());
                        txt = generator.Generation(userString, letters);
                        Printer.GenText(txt);
                        str.Sort(txt, out num);
                        Console.ReadKey();
                    break;

                    case '4':
                        Console.Clear();
                        Printer.Test(1);
                        testres = test.TestCase1();
                        Console.WriteLine(testres);
                        Printer.Test(2);
                        testres = test.TestCase2();
                        Console.WriteLine(testres);
                        Printer.Test(3);
                        testres = test.TestCase3();
                        Console.WriteLine(testres);
                        Console.ReadKey();
                        break;

                    case '5': 
                        Environment.Exit(0);
                    break;   

                    default:
                        Printer.EnCorrValue();
                    break;
                }
            }
        }
    }
}
