using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace tasknew
{
    public class AlphabetText
    {
        private string mTxt;
        public AlphabetText(string txt)
        {
            mTxt = txt;
        }

        public int Sort()
        {
            var result = (from c in mTxt where Char.IsLetter(c) select c).ToArray();
            for (int i = 1; i < mTxt.Length; i++)
            {
                if (mTxt[i - 1] > mTxt[i])
                {
                    return i + 1;
                }
            }
            Console.WriteLine("Текст в алфавитном порядке");
            return 0;
        }
    }
}
