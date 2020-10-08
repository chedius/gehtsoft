using System;

namespace Task_1_with_massive
{
    /*
        Класс TestCases с тестирующими функциями
    */
    public class TestCases
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