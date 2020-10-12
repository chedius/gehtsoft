using System;
using System.Collections.Generic;
public class Finder
{
    public List<string> FinderWords(string outputStr, string[] wWords, out List<int> collectionOccurrences, out List<string> collectionWords)
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
                int countOccurrences = (outputStr.Length - outputStr.Replace(i, "").Length) / i.Length;
                outputStr = outputStr.Replace(i, "");
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