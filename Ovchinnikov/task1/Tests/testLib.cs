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
            string str = generator.generate(1,6, "qwertyuioplkjhgfdsazxcvbnm", 1,5);
            work.working(str);
            string str1 = generator.generate(1, 5, "qwertyuioplkjhgfdsazxcvbnm", 1, 5);
            work.working(str1);
        }
        public void testAbc()
        {
            string str = generator.generate(1,5, "йцукенгшждлорпавячсмитqwertyuioplkjhgfdsazxcvbnm", 1,10);
            work.working(str);
            string str1 = generator.generate(1, 5, "qwertyuioplkjhgfdsazxcvbnm", 1, 5);
            work.working(str1);
        }
 
    }
}
