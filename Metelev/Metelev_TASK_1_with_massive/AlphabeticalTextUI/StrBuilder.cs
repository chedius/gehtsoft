using System.Text;
using System;

namespace Task_1_with_massive
{
    public class StrBuilder
    {
        /*
            Метод StrBuild получает на вход алфавит допустимых символов - validSymbols, длину будущей строки - strLenght, максимальную длинну слова - maxWordLength
            Выполняет генерацию рандомной строки и возвращает ёё
        */
        Random rnd = new Random();

        public string StrBuild(string validSymbols, int strLength, int maxWordLength) 
        {
            StringBuilder rndStr = new StringBuilder(strLength - 1);
            int position = 0;
            int count = 0;
            for (int i = 0; i < strLength; i++)
            {
                position = rnd.Next(0, validSymbols.Length-1);
                rndStr.Append(validSymbols[position]);
                count++;
                if (count % rnd.Next(1, maxWordLength) == 0)
                {
                    rndStr.Append(" ");
                }
                else if(count % maxWordLength == 0)
                {
                    rndStr.Append(" ");
                }
            }
            return rndStr.ToString(); 
        }
    }
}