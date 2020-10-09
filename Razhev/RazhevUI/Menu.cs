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
            Spliter InstanceSpliter1 = new Spliter();
            Print InstancePrint1 = new Print();
            Spliter InstanceSpliter2 = new Spliter();
            Print InstancePrint2 = new Print();
            ModificationsStr InstanceModificationsStr2 = new ModificationsStr();
            Spliter InstanceSpliter3 = new Spliter();
            Print InstancePrint3 = new Print();
            GeneratorRandowWords InstanceGeneratorRandowWords = new GeneratorRandowWords();
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
                        Finder InstanceFinder1 = new Finder(strDef);
                        failedwWords = InstanceFinder1.FinderWords(InstanceSpliter1.SpliterWords(strDef), out Occurrences, out wWords);
                        InstancePrint1.PrintFailedWords(failedwWords);
                        InstancePrint1.PrintResult(wWords, Occurrences);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Введите символы из которых хотели бы сгенерировать строку.");
                        string setUserStr = Console.ReadLine();
                        string str = InstanceModificationsStr2.GenerateStr(InstanceGeneratorRandowWords.RandomWords(5, 10, InstanceModificationsStr2.UserSetSymbols(setUserStr)));
                        Console.WriteLine("Сгенерированная строка: " + str);
                        Finder InstanceFinder2 = new Finder(str);
                        failedwWords = InstanceFinder2.FinderWords(InstanceSpliter2.SpliterWords(str), out Occurrences, out wWords);
                        InstancePrint2.PrintFailedWords(failedwWords);
                        InstancePrint2.PrintResult(wWords, Occurrences);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Вводите строку:");
                        string strUser = Console.ReadLine();
                        Finder InstanceFinder3 = new Finder(strUser);
                        failedwWords = InstanceFinder3.FinderWords(InstanceSpliter3.SpliterWords(strUser), out Occurrences, out wWords);
                        InstancePrint3.PrintFailedWords(failedwWords);
                        InstancePrint3.PrintResult(wWords, Occurrences);
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
                        Tests tests = new Tests();
                        Console.WriteLine(tests.RandomWordsTest());
                        Console.WriteLine(tests.GenerateStrTest());
                        Console.WriteLine(tests.SpliterWordsTest());
                        Console.WriteLine(tests.FinderWordsTest());
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