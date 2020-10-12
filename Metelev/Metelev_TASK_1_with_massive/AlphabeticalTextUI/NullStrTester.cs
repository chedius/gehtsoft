using System;

namespace Task_1_with_massive
{
    public class NullStrTester
    {
        public bool TestNullStr(string str)
        {
            if (str == "")
            {
                return false;
            }
            else return true;
        }
    }
}