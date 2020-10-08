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
        public void sendAbtInput()
        {
             Console.WriteLine("Введите слова через запятую на латинском алфавите с точкой в конце");
        }
        public void sendHello()
        {
            Console.WriteLine("Выберете способ ввода");
            Console.WriteLine("1:Ввод с консоли");
            Console.WriteLine("2:Использовать готовую строку");
            Console.WriteLine("3:Использовать генератор строки");
        }
    }

    /  public class generator 
      {
          Random rnd = new Random();
          
          public void generate(int maxLong, char[] Alphabet)
          {
            char[] str;
            int value = rnd.Next();
            int length = rnd.Next(0,30);
            for (int i = 0; i < length; i++)
            {

                int Position = rnd.Next(0, Alphabet.Length-1);

                str[i] = Alphabet[Position];
                return stri;

            }
            
            //char[] Alphabet= new List<string> {'q','w','e','r','t','y','u','i','o','p','a','s','d','f','g','h','j','k','l','z','x','c','v','b','n','m'};
          }
      }
}
