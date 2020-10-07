using System;
using System.Linq;

namespace tasknew
{
    public class AlphabetText
    {
        private string mTxt;

        public AlphabetText(string txt)
        {
            mTxt = txt;
        }

        public void Sort()
        {

            var result = (from c in mTxt where Char.IsLetter(c) select c).ToArray();

            int count = 0;

            for (int i = 1; i < result.Length; i++)
            {
                if (result[i - 1] > result[i])
                {
                    Console.WriteLine("{0} - первый символ, который нарушает алфавитный порядок", i + 1);
                    count++;
                }
                 
            }
            
            if(count == 0)
            {
                Console.WriteLine("Текст в алфавитном порядке");
            } 
        }
    }
}
