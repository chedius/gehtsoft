using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace Task_1_with_massive
{

    public class AlphabetSort
    {
        /*
            Функция Sort выполняет преобразование принятого текста Text, и возвращает преобразованную строку
        */
        NullStrTester test2 = new NullStrTester();
        StrPrinter msg1 = new StrPrinter();
        
        public string Sort(string Text)
        {
            int lenght = Text.Length;
            char[] letters = Text.ToCharArray();
            List<char> ListLetters = new List<char>();
            bool isNotNull;
            string nullStrng = msg1.nullStr;
            int a=0;
            for(int i=0; i<lenght; i++)
            {
                if(letters[i]>='а' && letters[i]<='я')
                {
                    ListLetters.Add(letters[i]);
                    a++;
                }
            }
            char[] newLetters = ListLetters.ToArray();
            int l = (new string(newLetters)).Length;
            int count = l;
            bool swaped;
            do
            {
                swaped = false;
                for(int i=1; i <= count-1;i++)
                {
                    if(newLetters[i]<newLetters[i-1])
                    {
                        char temp = newLetters[i];
                        newLetters[i]=newLetters[i-1];
                        newLetters[i-1]=temp;
                        swaped = true;
                    }
                }
                count--;
            
            } while(swaped);
            string newStr = string.Join("",newLetters);
            isNotNull = test2.TestNullStr(newStr);
            if (isNotNull == true)
            {
                return newStr;
            }
            else return nullStrng;
        }
    }
}