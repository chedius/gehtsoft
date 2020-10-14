using System;
//using System.Security.Cryptography.X509Certificates;
using CheckLib;
using sending;
using Tests;
using wokrWithString;

namespace main
{
    class main
    {
        static void Main(string[] args)
        {
            WorkerStr work = new WorkerStr();
            Checker check = new Checker();
            Sender msg = new Sender();
            Tester test = new Tester();
            while (true)
            {
                msg.SendHello();
                int answ = Console.ReadKey().KeyChar;
                switch (answ)
                {
                    case '1':
                        msg.Clear();
                        msg.SendAbtInput();
                        string str = Console.ReadLine();
                        work.Working(str);

                        break;

                    case '2':
                        msg.Clear();
                        string str1 = "first,word,last,life.ЫЫ";
                        work.Working(str1);
                        break;
                    case '3':
                        msg.Clear();
                        Generator generator = new Generator();
                        Tester tester = new Tester();
                        msg.SendHelloTest();
                        int ans = Console.ReadKey().KeyChar;
                        msg.Clear();
                        //string str2 = generator.generate(5, "qwertyuioplkjhgfdsazxcvbnm", 31);
                        switch (ans) {
                            case '1':
                                test.TestLong();
                                Console.ReadKey();
                                msg.Clear();
                                break;
                            case '2':
                                test.TestAbc();
                                Console.ReadKey();
                                msg.Clear();
                                break;
                            case '3':
                                test.TestLong();
                                Console.ReadKey();
                                msg.Clear();
                                break;
                        }
                    break;
                }
            }
        }
    }
}
