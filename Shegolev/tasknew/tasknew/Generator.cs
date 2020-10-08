using System;

namespace tasknew
{
    public class Generator
    {
        private char[] userSymbols;
        public Generator(char[] alphabet)
        {
            userSymbols = alphabet;
        }

        public string Generation(int letters) 
        {
            string str = "";          

            Random rand = new Random();

            for (int i = 1; i <= letters; i++) {
                int letters_num = rand.Next(0, userSymbols.Length - 1);
                str += userSymbols[letters_num];
            }
            return str;
        }
    }
}