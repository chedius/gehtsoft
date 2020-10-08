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
        public string StrBuild(string validSymbols, int strLength, int maxWordLength) 
        {
            TestCases test = new TestCases();
            ifStrNull:
            Random rnd = new Random(DateTime.Now.Millisecond);

            StringBuilder rndStr = new StringBuilder(strLength - 1);
            int position = 0;
            for (int i = 0; i < strLength; i++)
            {
                position = rnd.Next(0, strLength-1);
                rndStr.Append(validSymbols[position]);
                if (rndStr.Length % rnd.Next(1, maxWordLength) == 0)
                {
                    rndStr.Append(" ");
                }
                if(rndStr.Length % 30 == 0)
                {
                    rndStr.Append("\n");
                }
            }
            string rndStrng = rndStr.ToString();
            bool b = test.TestNullStr(rndStrng);
            if (b == true) 
            {
                return rndStrng;
            }
            else 
            {
                goto ifStrNull;
            }
        }
    }
}