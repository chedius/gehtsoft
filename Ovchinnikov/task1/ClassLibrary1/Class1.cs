using System;

namespace CheckLib
{
    public class checker
    {
        chekerProperties checkist = new chekerProperties();
        sender msg = new sender();

        public bool checkLong(string[] words)
        {
            bool flag = true;
            if (!checkist.longWrd(words))
            {
                msg.sendLong();
                flag = false;
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        public bool checkMuch(string[] words)
        {
            bool flag = true;

            if (!checkist.muchWrd(words))
            {
                msg.sendMuch();
                flag = false;
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        public bool checkAbc(string str)
        {
            bool flag = true;
            if (!checkist.Abc(str))
            {
                msg.sendAbc();
                flag = false;
            }
            else
            {
                flag = true;
            }
            return flag;
        }

    }
    public class chekerProperties
    {
        public bool longWrd(string[] words) //true- всё нормально
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
        public bool muchWrd(string[] words)
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
    }

    public class sender
    {
        public void noFoundedDot()
        {
            Console.WriteLine("Точка не найдена");
        }

        public void sendResult(string[] words)
        {
            for (int i = 0; i < words.Length - 1; i++)
            {
                Console.Write(words[words.Length - i - 1] + ',');

            }
            Console.Write(words[0] + '.');
            Console.WriteLine();
        }
        public void sendLong()
        {
            Console.WriteLine("Есть слишком длинное слово");
        }
        public void sendMuch()
        {
            Console.WriteLine("Cлишком много слов");
        }
        public void sendAbc()
        {
            Console.WriteLine("Есть символы, не являющиеся строчными латинскими буквами");
        }
    }

    /*  public class generator 
      {
          public string generate(int maxLong)
          {
              for (int i = 0; i <= ; i++)
                 rand.Next(27));

          }
      }*/
}
