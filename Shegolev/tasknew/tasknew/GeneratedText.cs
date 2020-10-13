using System;
using System.Collections.Generic;
using System.Text;

namespace tasknew
{
    class GenerateText
    {
        AlphabetText newtxt = new AlphabetText();
        int num;

        public int GeneratedText(out string genStr)
        {
            genStr = "АБВГДАБВЖАЗ.";
            newtxt.Sort(genStr, out num);
            return num;
        }
    }
}
