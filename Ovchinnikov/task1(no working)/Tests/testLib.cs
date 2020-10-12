using System;
using System.Text;
using CheckLib;
using sending;
using wokrWithString;


namespace Tests
{
    public class generator
    {
        Random rnd = new Random();
        public string generate(int minLong, int maxLongWord,  string alphabet, int minWords, int maxMuchWord)

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
            Console.WriteLine("Получилась строка: " + str);
            return str;

        }
    }

    public class tester
    {
        workerStr work = new workerStr();
        checker check = new checker();
        sender msg = new sender();
        generator generator = new generator();


        public void testLong()
        {
            string str = generator.generate(6,10, "qwertyuioplkjhgfdsazxcvbnm", 1,5);
            string[] words = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (check.checkLong(words) && check.checkMuch(words) && check.checkAbc(str) && check.checkEmpty(str))
            {
                msg.sendTrue();
            }
            else
            {
                msg.sendFalse();
            }

            string str1 = generator.generate(1, 5, "qwertyuioplkjhgfdsazxcvbnm", 1, 5);
            string[] words1 = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (check.checkLong(words1) && check.checkMuch(words1) && check.checkAbc(str1) && check.checkEmpty(str1))
            {
                msg.sendTrue();
            }
            else
            {
                msg.sendFalse();
            }
        }
        public void testAbc()
        {
            string str = generator.generate(1,5, "йцукенгшждлорпавячсмитqwertyuioplkjhgfdsazxcvbnm", 1,5);
            string[] words = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (check.checkAbc(str))
            {
                msg.sendTrue();
            }
            else
            {
                msg.sendFalse();
            }
            string str1 = generator.generate(1, 5, "qwertyuioplkjhgfdsazxcvbnm", 1, 5);
            string[] words1 = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (check.checkAbc(str1))
            {
                msg.sendTrue();
            }
            else
            {
                msg.sendFalse();
            }
        }
 
    }
}
