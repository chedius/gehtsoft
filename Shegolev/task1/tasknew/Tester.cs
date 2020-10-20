using System;

namespace tasknew
{
    public class Tester
    {
        AlphabetText teststr = new AlphabetText();
        int num;

        public bool TestCase1()
        {
            string str1 = "АБВГДЕЕЖ";
            teststr.Sort(str1, out num);
            if (num == 0)
            {
                return true;
            }
            else return false;
        }

        public bool TestCase2()
        {
            string str1 = "АбаГДеЕЖ";
            teststr.Sort(str1, out num);
            if (num == 3)
            {
                return true;
            }
            else return false;
        }

        public bool TestCase3()
        {
            string str1 = "абвгабва";
            teststr.Sort(str1, out num);
            if (num == 3)
            {
                return true;
            }
            else return false;
        }
    }
}
