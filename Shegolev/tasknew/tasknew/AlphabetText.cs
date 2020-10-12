using System;
using System.Linq;

namespace tasknew
{
    public class AlphabetText
    {
        //private string mTxt;

        public AlphabetText(string txt)
        {
        }

        public int Sort(string mTxt)
        {
            var result = (from c in mTxt where Char.IsLetter(c) select c).ToArray();
            int num = 0;

            for (int i = 1; i < result.Length; i++)
            {
                if (result[i - 1] > result[i])
                {
                    num = i + 1;
                    break;
                }
            }
            return num;
        }
    }
}
