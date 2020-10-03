using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Library_lab2;

namespace Study
{
    class Program
    {

        static string[] SearchWords(string text) {
            char[] delete_symbol = { ' ', ',', '.' };
            text = text.ToLower();
            text = text.Trim(delete_symbol);
            string[] arr_words = text.Split(',');
            return arr_words;
        }

        static void Contains(string str, string[] arr_words) {
            int k = 0;
            foreach (string i in arr_words)
            {
                if (i.Length < 1 || i.Length > 5) {
                    Console.WriteLine("Символ не проходит условие: " + i);
                    break;
                }
                k++;
                int count = (str.Length - str.Replace(i, "").Length) / i.Length;
                Console.WriteLine("{0}) Число вхождений слова {1}: {2}", k, i, count);
            }
        }

        static void Main(string[] args)
        {
            string str = "q,ww,ee,rr,ttt,yyyy,uuuuu,q,o,p,uuuuu,ss,dd,f,g,h,j,xx,zz,xx,cc,vv,bb,nn,mm,q,rty,yui,asd,uuuuu.";
            Console.WriteLine("Длинна строки: " + str.Length);
            Contains(str, SearchWords(str));
            Console.ReadKey();
        }
    }
}
