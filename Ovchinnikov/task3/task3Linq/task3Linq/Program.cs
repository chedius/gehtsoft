using System;
using System.Linq;
using System.Collections.Generic;
using massage;

namespace task3Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Sender msg = new Sender();
            int num = msg.SendInputNumber();
            char C = msg.SendInputChar();
            string str;
            int SumNum = 0;
            int SumLong = 0;

            List<string> A = new List<string>();
            for (int i = 0; i < num; i++)
            {
                str = msg.SendToInputString(i);
                A.Add(str);
                
            }
            SumNum = A.Count(s => s.StartsWith(C) && s.EndsWith(C) && s.Length > 1); 
            SumLong = A.Sum(s => s.Length);
            msg.SendResults(SumLong, SumNum);
        }
    }
}
