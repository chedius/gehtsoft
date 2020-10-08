using System;
using System.Security.Cryptography.X509Certificates;
using CheckLib;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            checker check = new checker();
            sender msg = new sender();
            while (true)
            {
                Console.WriteLine("Введите слова через запятую на латинском алфавите с точкой в конце");
                string str = Console.ReadLine();

                if (str.IndexOf('.') == -1)
                {
                    msg.noFoundedDot();
                }
                else
                {

                    str = str.Substring(0, str.IndexOf('.'));
                    string[] words = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    if (check.checkLong(words) && check.checkMuch(words) && check.checkAbc(str))
                    {
                        msg.sendResult(words);
                    }
                }
            }
        }
    }
}
