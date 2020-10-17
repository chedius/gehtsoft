using System;
using System.Collections.Generic;
class LenghtLines
{
    public List<int> FindLenghtLines(List<string> inputStr)
    {
        List<int> lenghtStr = new List<int>();
        for (int i = 0; i < inputStr.Count; i++)
        {
            lenghtStr.Add(inputStr[i].Length);
        }
        return lenghtStr;
    }
}