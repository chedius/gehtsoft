using System;
using System.Collections.Generic;
class ModificationsStr
{
    public char[] UserSetSymbols(string SetUserStr)
    {
        char[] symbols = SetUserStr.ToLower().ToCharArray();
        return symbols;
    }
    public string GenerateStr(List<string> collStr)
    {
        string resStr = "";
        if (collStr.Count == 0)
        {
            Console.WriteLine("Строка не сгенерировалась!Проверить генератор слов.");
        }
        else
        {
            foreach (var tempWord in collStr)
            {
                resStr += tempWord + " ";
            }
            resStr = resStr.Replace(' ', ',');
            resStr = resStr.TrimEnd(',');
            resStr += ".";
        }
        return resStr;
    }
}