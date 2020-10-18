using System;

namespace massage
{
    public class Sender
    {
        public int SendInputNumber()
        {
            Console.WriteLine("Input the number of strings");
            int res = Convert.ToInt32(Console.ReadLine());
            return res;
        }
        public char SendInputChar()
        {
            Console.WriteLine("Input char");
            char res = Console.ReadKey().KeyChar;
            Console.WriteLine();
            return res;
        }
        public string SendToInputString(int i)
        {
            Console.WriteLine("Input string number {0} ", i);
            string str = Console.ReadLine();
            return str;
        }
        public void SendResults(int SumLong, int SumNum)
        {
            Console.WriteLine("The number of lines starting and ending with this character {0}", SumNum);
            Console.WriteLine("Sum of line lengths {0}", SumLong);
        }
    }
}
