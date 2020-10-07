using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Task_1_with_massive
{
    public class Modification
    {
        public string Modificate(string Text)
        {
            int lenght = Text.Length;
            char[] letters = Text.ToCharArray();
            List<char> ListLetters = new List<char>();
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
                        swaped=true;
                    }
                }
                count--;
            
            } while(swaped);
            return new string(newLetters);
        }
    }
    public class StrBuilder
    {
        public string StrBuild(string validSymbols, int strLength, int maxWordLength ) 
        {
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
            return rndStr.ToString();
        }
    }
}