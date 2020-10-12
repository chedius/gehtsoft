using System;
using System.Collections.Generic;
namespace IntroUI
{
    public class Menu
    {
        static void Main(string[] args)
        {
            string strDef = "q,w,ee,rr,ttt,yyyy,uuuuu,q,o,p,uuuuu,ss,dd,f,g,h,j,xx,zz,xx,cc,vv,bb,nn,mm,q,rty,yui,asd,uuuuu.";
            List<string> failedwWords = new List<string>();
            List<int> Occurrences = new List<int>();
            List<string> wWords = new List<string>();
            Spliter InstanceSpliter = new Spliter();
            Finder InstanceFinder = new Finder();
            ModificationsStr InstanceModificationsStr = new ModificationsStr();
            Printer InstancePrint = new Printer();
            GeneratorRandowWords InstanceGeneratorRandomWords = new GeneratorRandowWords();
            Tests tests = new Tests();
            bool cycle = true;
            while (cycle == true)
            {
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("1.Выполнить программу с заданной строкой: " + strDef);
                Console.WriteLine("2.Выполнить программу при этом строка будет сгенерированна,введите символы из которых хотите сгенерировать строку.");
                Console.WriteLine("3.Выполнить программу строку вы вводите сами.");
                Console.WriteLine("4.Ознакомится с условиями ввода строки.");
                Console.WriteLine("5.Запустить тесты.");
                Console.WriteLine("6.Выход из программы.");
                int sWarg = Convert.ToInt32(Console.ReadLine());
                switch (sWarg)
                {
                    case 1:
                        Console.Clear();
                        failedwWords = InstanceFinder.FinderWords(strDef, InstanceSpliter.SpliterWords(strDef), out Occurrences, out wWords);
                        InstancePrint.PrintFailedWords(failedwWords);
                        InstancePrint.PrintResult(wWords, Occurrences);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Введите символы из которых хотели бы сгенерировать строку.");
                        string setUserStr = Console.ReadLine();
                        string str = InstanceModificationsStr.GenerateStr(InstanceGeneratorRandomWords.GenerateRandomWords(5, 10, InstanceModificationsStr.UserSetSymbols(setUserStr)));
                        Console.WriteLine("Сгенерированная строка: " + str);
                        failedwWords = InstanceFinder.FinderWords(str, InstanceSpliter.SpliterWords(str), out Occurrences, out wWords);
                        InstancePrint.PrintFailedWords(failedwWords);
                        InstancePrint.PrintResult(wWords, Occurrences);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Вводите строку:");
                        string strUser = Console.ReadLine();
                        failedwWords = InstanceFinder.FinderWords(strUser, InstanceSpliter.SpliterWords(strUser), out Occurrences, out wWords);
                        InstancePrint.PrintFailedWords(failedwWords);
                        InstancePrint.PrintResult(wWords, Occurrences);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Длина символа не должна быть меньше чем 1 или больше чем 5.");
                        Console.WriteLine("Слов в строке должно быть не больше чем 30.");
                        Console.WriteLine("Соседниеи слова разделены (,) а в конце (.).");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Тесты:");
                        Console.WriteLine(tests.RandomWordsTest());
                        Console.WriteLine(tests.GenerateStrTest());
                        Console.WriteLine(tests.SpliterWordsTest());
                        Console.WriteLine(tests.FinderWordsTest());
                        Console.WriteLine("----------------------");
                        break;
                    case 6:
                        cycle = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Вы ничего не выбрали!");
                        break;
                }
            }
        }
    }
}