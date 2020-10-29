using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace ChatClient
{
    class Program
    {
        static string userName;
        private const string host = "127.0.0.1";
        private const int port = 8888;
        static TcpClient client;
        static NetworkStream stream;
        private static int count = 0;
        private static bool f = true;
        private static string[] TextArr = new string[7];
        private const int numTexts = 7;
 
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            userName = Console.ReadLine();
            client = new TcpClient();
            try
            {
                client.Connect(host, port);
                stream = client.GetStream();
                byte[] data = Encoding.Unicode.GetBytes(userName);
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Добро пожаловать, {0}", userName);
                while (count < numTexts)
                {
                    string text = ReceiveMessage();
                    CheckText(text);
                    Thread.Sleep(5000);
                }
                Console.WriteLine("Все строки успешно получены");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }

            
            Console.WriteLine("Все тексты получены");
        }
        // получение сообщений
        static string ReceiveMessage()
        {
                Console.WriteLine("Запрашивается текст");
                byte[] data = new byte[64];
                StringBuilder builder = new StringBuilder();
                int bytes = 0;
                do
                {
                    bytes = stream.Read(data, 0, data.Length);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);
                string text = builder.ToString();
                Console.WriteLine("Отправляем текст " + text + " на проверку");
                return text;
        }

        static void CheckText(string text)
        {
            if(TextArr[0] == null)
            {
                TextArr[0] = text;
                GetVowAndCon(TextArr[0], count);
                GetUniqWords(TextArr[0], count);
                count++;
                Console.WriteLine("Текст готов!");
            }
            else
            {
                for(int i = 0; i < count; i++)
                {
                    if(TextArr[i] == text)
                    {
                        Console.WriteLine("Такой текст уже был!");
                        f = false;
                        break;
                    }
                    else
                    {
                        f = true;
                    }
                }
                if(f == true)
                {
                    TextArr[count] = text;
                    GetVowAndCon(TextArr[count], count);
                    GetUniqWords(TextArr[count], count);
                   count++;
                    Console.WriteLine("Текст готов!");
                }
            }
        }

        static void GetVowAndCon(string mtext, int number)
        {
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            var consonants = new HashSet<char> { 'q', 'w', 'r', 't', 'y', 'p', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            string vowTxt = new string(mtext.ToLower().Where(c=>vowels.Contains(c)).ToArray());
            string conTxt = new string(mtext.ToLower().Where(c=>consonants.Contains(c)).ToArray());
            string totalVow = new string(vowTxt.Count() + " ," + vowTxt);
            string totalCon = new string(conTxt.Count() + " ," + conTxt);
            PrintInFile(totalVow, "vowels", number);
            PrintInFile(totalCon, "consonants", number);
        }
        static void GetUniqWords(string text, int number)
        {
            Regex req_exp = new Regex("[^a-zA-Z0-9]");
            text = req_exp.Replace(text, " ");

            string[] words = text.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            var word_query = (from string word in words orderby word select word).Distinct();
            string[] noResult = word_query.ToArray();

            string result = null;
            for (int i = 0; i < noResult.Length; i++)
            {
                result += noResult[i];
                result += " ";
            }
            PrintInFile(result, "uniq", number);

        }
        static void PrintInFile(string res, string name, int number)
        {
            using (FileStream fstream = new FileStream($"../{name}{number}.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(res);
                fstream.Write(array, 0, array.Length);
            }
        }
        static void Disconnect()
        {
            if(stream!=null)
                stream.Close();//отключение потока
            if(client!=null)
                client.Close();//отключение клиента
            Environment.Exit(0); //завершение процесса
        }
    }
}