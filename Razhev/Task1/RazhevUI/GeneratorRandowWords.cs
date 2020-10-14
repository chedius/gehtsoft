using System;
using System.Collections.Generic;
class GeneratorRandowWords
{
    /* Метод GenerateRandomWords генерирует рандомные слова в диапазоне от количества символов в слове до количества слов */
    Random rnd = new Random();

    public List<string> GenerateRandomWords(int lenghtSymbols, int countWords, char[] symbols)
    {
        List<string> strCollection = new List<string>();
        if (lenghtSymbols <= 0 & countWords <= 0)
        {
            Console.WriteLine("Введённые параметры генератора должны быть больше 0!");
        }
        else
        {
            for (int i = 1; i <= countWords; i++)
            {
                string strWords = "";
                for (int j = 1; j <= lenghtSymbols; j++)
                {
                    int indexletter = rnd.Next(0, symbols.Length - 1);
                    strWords += symbols[indexletter];
                }
                strCollection.Add(strWords);
            }
        }
        return strCollection;
    }
}