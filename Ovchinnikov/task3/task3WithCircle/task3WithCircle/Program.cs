using System;
using massage;

namespace Task3Circle
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


            for (int i = 0; i < num; i++)
            {

                str = msg.SendToInputString(i);
                if (str.Length > 1 && str[0] == C && str[str.Length - 1] == C)
                {
                    SumNum += 1;
                }
                SumLong += str.Length;
            }
            msg.SendResults(SumLong, SumNum);
        }
    }
}
