using System;

namespace tasknew
{
    public class Tests
    {
        public bool TestCase() {
            string txt = "АБВ ГА.";
            AlphabetText text = new AlphabetText(txt);
            //int pos;
            int i = text.Sort(txt);
            if (i == 0)
            {
                return true;
            }
            else 
            //Console.WriteLine(i);
            return false;
        }
    
        public bool TestCase2() 
        {
            string txt = "А БВ ГДЕ.";
            AlphabetText text = new AlphabetText(txt);
            //int pos;
            int i = text.Sort(txt);
            if (i == 0)
            {
                return true;
            }
            else return false;
        }
    }
}