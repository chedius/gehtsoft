using System;
using System.Collections.Generic;
using System.Text;

namespace tasknew
{
    class GeneratedText
    {
        public GeneratedText()
        {
            string str = "АБ АВ";
            Console.WriteLine("Исходный текст: " + str);
            AlphabetText newtxt = new AlphabetText(str);
            newtxt.Sort();
        }
    }
}
