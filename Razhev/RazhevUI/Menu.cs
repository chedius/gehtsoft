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
                InstancePrint.OutputMenu(strDef);
                int sWarg = Convert.ToInt32(Console.ReadLine());
                switch (sWarg)
                {
                    case 1:
                        Console.Clear();
                        failedwWords = InstanceFinder.FinderWords(strDef, InstanceSpliter.SpliterWords(strDef), out Occurrences, out wWords);
                        InstancePrint.OutputFailedWords(failedwWords);
                        InstancePrint.OutputResult(wWords, Occurrences);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Введите символы из которых хотели бы сгенерировать строку.");
                        string setUserStr = Console.ReadLine();
                        string str = InstanceModificationsStr.GenerateStr(InstanceGeneratorRandomWords.GenerateRandomWords(5, 10, InstanceModificationsStr.InputUserSymbols(setUserStr)));
                        Console.WriteLine("Сгенерированная строка: " + str);
                        failedwWords = InstanceFinder.FinderWords(str, InstanceSpliter.SpliterWords(str), out Occurrences, out wWords);
                        InstancePrint.OutputFailedWords(failedwWords);
                        InstancePrint.OutputResult(wWords, Occurrences);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Вводите строку:");
                        string strUser = Console.ReadLine();
                        failedwWords = InstanceFinder.FinderWords(strUser, InstanceSpliter.SpliterWords(strUser), out Occurrences, out wWords);
                        InstancePrint.OutputFailedWords(failedwWords);
                        InstancePrint.OutputResult(wWords, Occurrences);
                        break;
                    case 4:
                        InstancePrint.FamiliarizesWithConditions();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Тесты:");
                        tests.RandomWordsTest();
                        tests.GenerateStrTest();
                        tests.SpliterWordsTest();
                        tests.FinderWordsTest();
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