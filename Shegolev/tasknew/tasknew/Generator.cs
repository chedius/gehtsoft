using System;

namespace tasknew
{
    public class Generator
    {
        public Generator(string alphabet)
        {
            string str = "";
            Console.WriteLine("Введите алфавит:");
            char[] symbols =Console.ReadLine().ToCharArray();
        }

        public string Generation(int letters) 
        {
            string str = "";
            char[] symbols = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
            
            Random rand = new Random();

            for (int i = 1; i <= letters; i++) {
                int letters_num = rand.Next(0, symbols.Length - 1);
                str += symbols[letters_num];
            }
            return str;
        }
    }
}