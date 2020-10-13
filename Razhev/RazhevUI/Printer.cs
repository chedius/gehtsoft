using System;
using System.Collections.Generic;
class Printer
{
    public void FamiliarizesWithConditions()
    {
        Console.Clear();
        Console.WriteLine("Длина символа не должна быть меньше чем 1 или больше чем 5.");
        Console.WriteLine("Слов в строке должно быть не больше чем 30.");
        Console.WriteLine("Соседниеи слова разделены (,) а в конце (.).");
    }
    public void OutputMenu(string strDef)
    {
        Console.WriteLine("Выберите действие: ");
        Console.WriteLine("1.Выполнить программу с заданной строкой: " + strDef);
        Console.WriteLine("2.Выполнить программу при этом строка будет сгенерированна,введите символы из которых хотите сгенерировать строку.");
        Console.WriteLine("3.Выполнить программу строку вы вводите сами.");
        Console.WriteLine("4.Ознакомится с условиями ввода строки.");
        Console.WriteLine("5.Запустить тесты.");
        Console.WriteLine("6.Выход из программы.");
    }
    public void OutputFailedWords(List<string> failedwWords)
    {
        if (failedwWords.Count != 0)
        {
            foreach (var i in failedwWords)
            {
                Console.WriteLine("Данное(ые) слово не прошло проверку по условиям: {0}", i);
            }
        }
        else
        {
            Console.WriteLine("Слов неудовлетворяющих условиям не обнаружено!");
        }
    }

    public void OutputResult(List<string> resWords, List<int> countOccurrences)
    {
        for (int i = 0; i < resWords.Count; i++)
        {
            Console.WriteLine("{0})Число вхождений слова {1}: {2}", i, resWords[i], countOccurrences[i]);
        }
    }
}