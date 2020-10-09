using System;
using System.Collections.Generic;
class Print
{
    public void PrintFailedWords(List<string> failedwWords)
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

    public void PrintResult(List<string> resWords, List<int> countOccurrences)
    {
        for (int i = 0; i < resWords.Count; i++)
        {
            Console.WriteLine("{0})Число вхождений слова {1}: {2}", i, resWords[i], countOccurrences[i]);
        }
    }
}