using System;
using System.Collections.Generic;
public class Finder
{


    private string mStr;

    public Finder(string str)
    {
        mStr = str;
    }

    public List<string> FinderWords(string[] wWords, out List<int> collectionOccurrences, out List<string> collectionWords)
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
                int countOccurrences = (mStr.Length - mStr.Replace(i, "").Length) / i.Length;
                mStr = mStr.Replace(i, "");
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