using System;
using System.Linq;

namespace Task_1_with_massive
{
    /*
        Класс Tester с тестирующими функциями
    */
    public class Tester
    {
        Modification test3 = new Modification();
        StrBuilder test4 = new StrBuilder();
        public bool TestNullStr(string str)
        {
            if (str == "")
            {
                return false;
            }
            else return true;
        }

        public bool TestMod()
        {   
            string tstStr = "вадим";
            string res = "авдим";
            if (res == test3.Modificate(tstStr))
            {
                return true;
            }
            else return false;

        }

        public bool TestGen()
        {
            string tAlphabet = "qwertyйцуке12345";
            int tStrLength = 70;
            int tMaxLengthWord = 5;
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
                        break;
                    }
                }
                return true;
            }
            else return false;
        }
    }
}