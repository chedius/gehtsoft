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
                msg.sendHello();
                int answ = Console.ReadKey().KeyChar;
                switch(answ)
                {
                    case '1':
                    Console.Clear();
                    msg.sendAbtInput();
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
                    break;

                    case '2':
                    Console.Clear();
                    string str1 = "first,word,last,life.ЫЫ";
                    if (str1.IndexOf('.') == -1)
                    {
                        msg.noFoundedDot();
                    }
                    else
                    {

                        str1 = str1.Substring(0, str1.IndexOf('.'));
                        string[] words = str1.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        if (check.checkLong(words) && check.checkMuch(words) && check.checkAbc(str1))
                        {
                            msg.sendResult(words);
                        }
                    }
                    break;
                    case '3':
                    Console.Clear();
                    //generator generator = new generator();
                    //char[] Alphabet =
                    //generator.generate();
                    break;
                }
            }
        }
    }
}
