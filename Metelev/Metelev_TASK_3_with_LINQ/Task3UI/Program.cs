using System;
using System.Collections.Generic;

namespace Task3UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Reverser rvr = new Reverser();
            Printer prt = new Printer();
            int num;
            num = prt.GetNum();
            string str;
            List<string> strList = new List<string>();
            for (int i = 0; i < num; i++)
            {
                str = prt.GetStr(i);
                strList.Add(str);
            }
            string s = rvr.ReverseOrder(num, strList);
            prt.PrintRes(s);

        }
    }
}
