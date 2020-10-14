using System;
using System.Collections.Generic;
class ModificationsStr
{
    /* Метод InputUserSymbols разбивает строку символов на массив символов */
    public char[] InputUserSymbols(string SetUserStr)
    {
        char[] symbols = SetUserStr.ToLower().ToCharArray();
        return symbols;
    }

    /* Метод GenerateStr из массива символов создаёт строку по условию 
       Пример:
       abc
       a,b,c.
     */
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