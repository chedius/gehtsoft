using System;
using System.Collections.Generic;
public class Finder
{
    /* Метод  FinderWords считает количество вхождений слова в строке и возвращает слова которые не прошли проверку
       так же возвращает лист вхождений через out и лист слов
    */
    public List<string> FinderWords(string inputStr, string[] wWords, out List<int> collectionOccurrences, out List<string> collectionWords)
    {
        List<string> collectionWordFailed = new List<string>();
        collectionWords = new List<string>();
        collectionOccurrences = new List<int>();
        foreach (var i in wWords)
        {
            if (i.Length < 1 || i.Length > 5)
            {
                collectionWordFailed.Add(i);
                break;
            }
            else
            {
                int countOccurrences = (inputStr.Length - inputStr.Replace(i, "").Length) / i.Length;
                inputStr = inputStr.Replace(i, "");
                if (countOccurrences == 0)
                {
                    continue;
                }
                else
                {
                    collectionWords.Add(i);
                    collectionOccurrences.Add(countOccurrences);
                }
            }
        }
        return collectionWordFailed;
    }
}