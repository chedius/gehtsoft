using System;

public class InstanseFinder : Spliter
{
    private string mStr;

    public InstanseFinder(string str)
    {
        mStr = str;
    }

    public void InstanseFinderWords()
    {
        string[] arr_words = SpliterWords(mStr);
        int k = 0;
        Console.WriteLine("Длина строки: " + mStr.Length);
        foreach (var i in arr_words)
        {
            if (i.Length < 1 || i.Length > 5)
            {
                Console.WriteLine("Данное слово не проходит по условиям: " + i);
                break;
            }
            else
            {
                k++;
                int count = (mStr.Length - mStr.Replace(i, "").Length) / i.Length;
                Console.WriteLine("{0} Число вхождений данного слова в строку {1}: {2}", k, i, count);
            }
        }
    }

}