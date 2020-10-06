using System;
using System.Dynamic;

namespace Lib1
{
    public class Class1
    {
        public static bool longWrd(string str)  
        {
            bool result = true;
            string[] words = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int amtWrd = words.Length;
            for (int i = 0; i < amtWrd; i++)
            {
                int lenWrd = words[i].Length;
                if (lenWrd > 5)
                {
                    result = false;
                    break;
                }
                else
                {
                    result = true;
                }
            }
            return result;
        }

        public static bool muchWrd(string str) 
        {
            bool result = true;
            string[] words = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int amtWrd = words.Length;
            if (amtWrd > 30)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }


        public static void writeStr(string str) 
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


        public static string lastSimb(string str)
        {
            int numSymb = str.Length;
            if (str[numSymb - 1] == '.')
            {
                string str1 = str.Remove(str.Length - 1);
                return str1;
            }
            else
            {
                return str;
            }
        }
        public static bool CheckLast(string str)
        {
            bool flag = true;
            int numSymb = str.Length;
            if (str[numSymb - 1] != '.')
            {
                flag = false;
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        public static bool Abc(string str)
        {
            int length = str.Length;
            bool flag = true;
            for (int i = 0; i < length; i++)
            {
                if ((int)str[i] >= 97 && (int)str[i] <= 122)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }

       
    }
}
