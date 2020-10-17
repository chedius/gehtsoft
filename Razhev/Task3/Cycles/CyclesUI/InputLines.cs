using System;
using System.Collections.Generic;
class InputLines
{
    public List<string> EnterNumberLines(int countStr)
    {
        List<string> strColl = new List<string>();
        while (countStr > 0)
        {
            string inputStr = new string(Console.ReadLine());
            strColl.Add(inputStr);
            countStr--;
        }
        return strColl;
    }
}