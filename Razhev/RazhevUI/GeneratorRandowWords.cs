using System;
using System.Collections.Generic;
class GeneratorRandowWords
{
    Random rnd = new Random();
    public List<string> RandomWords(int letters, int words, char[] symbols)
    {
        List<string> strCollection = new List<string>();
        if (letters <= 0 & words <= 0)
        {
            Console.WriteLine("Введённые параметры генератора должны быть больше 0!");
        }
        else
        {
            for (int i = 1; i <= words; i++)
            {
                string strWords = "";
                for (int j = 1; j <= letters; j++)
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