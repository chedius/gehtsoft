using System;
using System.Collections.Generic;
using System.Text;

namespace tasknew
{
    class GenerateText
    {
        public int GeneratedText(string str)
        {
            AlphabetText newtxt = new AlphabetText(str);
            return newtxt.Sort(str);
        }
    }
}
