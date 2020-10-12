using System;
using System.Linq;

namespace Task_1_with_massive
{
    /*
        Класс Tester с тестирующими функциями
    */
    public class Tester
    {
        AlphabetSort test3 = new AlphabetSort();
        StrBuilder test4 = new StrBuilder();

        public bool TestMod()
        {   
            string tstStr = "вадим";
            string res = "авдим";
            if (res == test3.Sort(tstStr))
            {
                return true;
            }
            else return false;

        }

        public bool TestGen()
        {
            string tAlphabet = "qwertyйцуке12345";
            int tStrLength = 70;
            int tMaxLengthWord = 7;
            string genStr = test4.StrBuild(tAlphabet, tStrLength, tMaxLengthWord);
            var tWords = genStr.Split(' ').ToList();
            if(genStr.Replace(" ", "").Length == tStrLength)
            {
                foreach(var i in tWords)
                {
                    if( i.Length <= tMaxLengthWord)
                    {
                        return true;
                    }
                    else 
                    {
                        return false;
                    }
                }
                return true;
            }
            else return false;
        }
    }
}