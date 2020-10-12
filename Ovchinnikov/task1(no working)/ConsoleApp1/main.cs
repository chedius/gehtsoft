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
            workerStr work = new workerStr();
            checker check = new checker();
            sender msg = new sender();
            tester test = new tester();
            while (true)
            {
                msg.sendHello();
                int answ = Console.ReadKey().KeyChar;
                switch (answ)
                {
                    case '1':
                        Console.Clear();
                        msg.sendAbtInput();
                        string str = Console.ReadLine();
                        work.working(str);

                        break;

                    case '2':
                        Console.Clear();
                        string str1 = "first,word,last,life.ЫЫ";
                        work.working(str1);
                        break;
                    case '3':
                        Console.Clear();
                        generator generator = new generator();
                        tester tester = new tester();
                        msg.sendHelloTest();
                        int ans = Console.ReadKey().KeyChar;
                        Console.Clear();
                        //string str2 = generator.generate(5, "qwertyuioplkjhgfdsazxcvbnm", 31);
                        switch (ans) {
                            case '1':
                                test.testLong();
                                Console.ReadKey();
                                Console.Clear();
                            break;
                            case '2':
                                test.testAbc();
                                Console.ReadKey();
                                Console.Clear();
                            break;
                        }
                    break;
                }
            }
        }
    }
}
