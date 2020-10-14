using System;
using System.Text;
using sending;

namespace CheckLib
{
    public class Checker
    {
        ChekerProperties checkist = new ChekerProperties();
        Sender msg = new Sender();

        public bool Check(string[] words, string str)
        {
            bool result;

            if (CheckLong(words) && CheckMuch(words) && CheckAbc(str) && CheckEmpty(str))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public bool CheckLong(string[] words)
        {
            bool flag = true;
            if (!checkist.LongWrd(words))
            {
                msg.SendLong();
                flag = false;
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        public bool CheckMuch(string[] words)
        {
            bool flag = true;

            if (!checkist.MuchWrd(words))
            {
                msg.SendMuch();
                flag = false;
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        public bool CheckAbc(string str)
        {
            bool flag = true;
            if (!checkist.Abc(str))
            {
                msg.SendAbc();
                flag = false;
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        public bool CheckEmpty(string str)
        {
            bool flag = true;
            if (!checkist.Empty(str))
            {
                msg.SendEmpty();
                flag = false;
            }
            else
            {
                flag = true;
            }
            return flag;
        }
    }
    public class ChekerProperties
    {
        public bool LongWrd(string[] words) //true- всё нормально
        {
            bool result = true;
            for (int i = 0; i < words.Length; i++)
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
        public bool MuchWrd(string[] words)
        {
            bool result = true;

            if (words.Length > 30)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }
        public bool Abc(string str)
        {
            bool flag = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (((int)str[i] >= 97 && (int)str[i] <= 122) || str[i] == ',' || str[i] == '.') //97-'a', 122-'z' в аски коде
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        public bool Empty(string str)
        {

            bool result = true;
            if (str[0] == ',')
            {
                result = false;
            }
            else
            {
                for (int i = 1; i < str.Length; i++)
                {
                    if (str[i] == ',' && str[i + 1] == ',')
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;   
        }
    }
}
