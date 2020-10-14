using System;
using System.Text;
using CheckLib;
using sending;
using wokrWithString;


namespace Tests
{
    public class Generator
    {
        Random rnd = new Random();
        public string Generate(int minLong, int maxLongWord,  string alphabet, int minWords, int maxMuchWord)

        {
            StringBuilder rndStr = new StringBuilder(maxLongWord - 1);
            string str = "";
            int muchWrd = rnd.Next(minWords, maxLongWord);

            for (int j = 0; j < muchWrd-1; j++)
            {
                int longNewWrd = rnd.Next(minLong, maxLongWord);
                for (int i = 0; i < longNewWrd; i++)
                {

                    int Position = rnd.Next(0, alphabet.Length - 1);

                    str += alphabet[Position];
                }
                str += ",";
            }
            for (int i = 0; i < maxLongWord; i++)
            {

                int Position = rnd.Next(0, alphabet.Length - 1);

                str += alphabet[Position];
            }
            str += ".";
            Console.WriteLine("The resulting string: " + str);
            return str;

        }
    }

    public class Tester
    {
        WorkerStr work = new WorkerStr();
        Checker check = new Checker();
        Sender msg = new Sender();
        Generator generator = new Generator();


        public void TestLong()
        {
            string str = "one,winter,two.";
            string[] words = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (!check.Check(words, str))
            {
                msg.SendTrue();      
            }
            else
            {
                msg.SendFalse();
            }

        }
        public void TestAbc()
        {
            string str = "one,wnтриr,two.";
            string[] words = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (!check.Check(words, str))
            {
                msg.SendTrue();
            }
            else
            {
                msg.SendFalse();
            }

        }
        public void TestMuch()
        {
            string str = "one,win,two,win,two,win,two,win,two,win,two,win,two,win,two,win,two,win,two,win,two,win,two,win,two,win,two,win,two,win,two.";
            string[] words = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (!check.Check(words, str))
            {
                msg.SendTrue();
            }
            else
            {
                msg.SendFalse();
            }

        }

    }
}
