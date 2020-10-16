using System;

namespace sending
{
    public class Sender
    {
        public void NoFoundedDot()
        {
            Console.WriteLine("Dot not found");
        }

        public void SendResult(string[] words)
        {
            for (int i = 0; i < words.Length - 1; i++)
            {
                Console.Write(words[words.Length - i - 1] + ',');

            }
            Console.Write(words[0] + '.');
            Console.WriteLine();
        }
        public void SendLong()
        {
            Console.WriteLine("There is a word too long");
        }
        public void SendMuch()
        {
            Console.WriteLine("Too many words");
        }
        public void SendAbc()
        {
            Console.WriteLine("There are characters that are not lowercase Latin letters");
        }
        public void SendAbtInput()
        {
            Console.WriteLine("Enter words separated by commas in the Latin alphabet with a period at the end");
        }
        public void SendEmpty()
        {
            Console.WriteLine("Empty word");
        }

        public void SendHello()
        {
            Console.WriteLine("Choose input method");
            Console.WriteLine("1:Console input");
            Console.WriteLine("2:Use a prepared string");
            Console.WriteLine("3:Tests");
        }
        public void SendHelloTest()
        {
            Console.WriteLine("Which property do you want to test?");
            Console.WriteLine("1:Length of words");
            Console.WriteLine("2:Alphabet");
            Console.WriteLine("3:Much of words");
        }
        public void Clear()
        {
            Console.Clear();
        }
        public void SendTrue()
        {
            Console.WriteLine("True");
        }
        public void SendFalse()
        {
            Console.WriteLine("False");
        }
        public void ReadKey()
        {
            Console.ReadKey();
        }
        public int ReadKeyChar()
        {
            return Console.ReadKey().KeyChar;
        }
        public string ReadLine()
        {
           return Console.ReadLine();
        }
    }

}
