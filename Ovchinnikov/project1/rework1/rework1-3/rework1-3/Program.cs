using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace rework1_3
{
    class Program : BuildStr
    {
        static void Main(string[] args)
        {
         new BuildStr();
        }
    }

    public class BuildStr
    {
        public BuildStr()
        {
            string str = "first,word,last.Just word";
            Console.WriteLine("Готовый текст\n" + str);
            if (str.IndexOf('.') == -1)
            {
                Console.WriteLine("Точка не найдена");
            }
            
            
            else {
                str = str.Substring(0, str.IndexOf('.'));
                new ReverseStr(str);
            }
        }

    }

    public class ReverseStr
    {
        public ReverseStr(string str)
            {
                string[] words = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                int amtWrd = words.Length;
                for (int i = 0; i < amtWrd - 1; i++)
                {
                    Console.Write(words[amtWrd - i - 1]);
                    Console.Write(',');
                }
                Console.Write(words[0]);
                Console.Write('.');
            }
    }
}